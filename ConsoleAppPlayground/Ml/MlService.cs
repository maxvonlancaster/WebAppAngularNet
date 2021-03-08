using ConsoleAppPlayground.Ml.Models;
using Microsoft.ML.Data;
using Microsoft.ML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPlayground.Ml
{
    public class MlService : IMlService
    {
        public void Main()
        {
            Console.WriteLine("This is MlService");
            IrisTesting();
        }

        public void IrisTesting() 
        {
            var mlContext = new MLContext();
            var reader = mlContext.Data.CreateTextLoader<IrisData>(separatorChar: ',', hasHeader: true);
            IDataView trainingDataView = reader.Load("./../../../Ml/iris.txt");

            var pipeline = mlContext.Transforms.Conversion.MapValueToKey("Label")
                .Append(mlContext.Transforms.Concatenate("Features", "SepalLength", "SepalWidth", "PetalLength", "PetalWidth"))
                .Append(mlContext.MulticlassClassification.Trainers
                    .SdcaNonCalibrated(labelColumnName: "Label", featureColumnName: "Features"))
                .Append(mlContext.Transforms.Conversion.MapKeyToValue("PredictedLabel"));

            // Шаг 4: обучите модель на этом дата-сете
            var model = pipeline.Fit(trainingDataView);

            // Шаг 5: используйте модель для предсказания
            // Вы можете изменить эти цифры, чтобы проверить разные прогнозы
            var prediction = mlContext.Model.CreatePredictionEngine<IrisData, IrisPrediction>(model).Predict(
                new IrisData()
                {
                    SepalLength = 3.3f,
                    SepalWidth = 1.6f,
                    PetalLength = 0.2f,
                    PetalWidth = 5.1f,
                });

            Console.WriteLine($"Predicted flower type is: {prediction.PredictedLabels}");
        }
    }
}
