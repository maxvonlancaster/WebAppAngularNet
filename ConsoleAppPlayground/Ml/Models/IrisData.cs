using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPlayground.Ml.Models
{
    public class IrisData
    {
        // Шаг 1: Определите ваши структуры данных
        // IrisData используется для предоставления обучающих данных, а также
        // как введение для предиктивных операций
        // - Первые 4 свойства -- это входные данные / функции, используемые для прогнозирования метки label
        // - Label -- это то, что вы предсказываете, и устанавливается только при обучении
        [LoadColumn(0)]
        public float SepalLength;

        [LoadColumn(1)]
        public float SepalWidth;

        [LoadColumn(2)]
        public float PetalLength;

        [LoadColumn(3)]
        public float PetalWidth;

        [LoadColumn(4)]
        public string Label;
    }

    // IrisPrediction является результатом, возвращенным из операций прогнозирования
    public class IrisPrediction
    {
        [ColumnName("PredictedLabel")]
        public string PredictedLabels;
    }
}
