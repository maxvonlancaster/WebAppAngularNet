using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppPlayground.Hypothesis
{
    public abstract class Service : IService
    {
        public abstract void MethodMain();

        public void Method() 
        {
            Console.WriteLine("Method");
        }
    }
}
