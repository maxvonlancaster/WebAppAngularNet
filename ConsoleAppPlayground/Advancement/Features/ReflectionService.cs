using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ConsoleAppPlayground.Advancement.Features
{
    public class ReflectionService
    {
        public void Main() 
        {
            Basics();
            Usage();
            DynamicLoad();
            AttributeUsage();
        }

        // Main functionality on reflection is in System.Reflection 
        public void Basics() 
        {
            // Assembly - class that represents an assembly;
            // AssemblyName - info about assembly
            var assemblyName = Assembly.GetExecutingAssembly().GetName();
            Console.WriteLine("Current assembly name: " 
                + Assembly.GetExecutingAssembly().GetName().FullName);
            Console.WriteLine("Location of the current assembly as an URL: "
                + Assembly.GetExecutingAssembly().GetName().CodeBase);
            Console.WriteLine("Current assembly version: "
                + Assembly.GetExecutingAssembly().GetName().Version);

            // System.Type - incapsulates all the info about type - methods, properties, etc,
            // 
            Type type = typeof(SomeClass);
            MethodInfo methodInfo = type.GetMethod("Add");
            Console.WriteLine("Method name: "
                + methodInfo.Name);
            Console.WriteLine("Method's declaring type: "
                + methodInfo.DeclaringType.Name);
            Console.WriteLine("Method's return type: "
                + methodInfo.ReturnType.Name);
            Console.WriteLine("Method is or not static: "
                + methodInfo.IsStatic);
        }

        public void Usage() 
        {
        
        }

        public void DynamicLoad() 
        {
        
        }

        public void AttributeUsage() 
        {
        
        }
    }

    public class SomeClass 
    {
        public int Id { get; set; }
        private string Name { get; set; }
        public int Add(int i, int j) => i + j;
        public int Mult(int i, int j) => i * j;


    }
}
