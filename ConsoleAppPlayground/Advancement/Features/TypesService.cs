using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPlayground.Advancement.Features
{
    public class TypesService
    {
        public void Main()
        { 
        
        }

        public void MethodOverloading() 
        {
            NewClass newClass = new NewClass();
            newClass.Add(1, 2);
            newClass.Add(1, 2, 3);
            newClass.Add("1", "2");
            // method overloading -> when need to use one and the same param with different set of params
        }
    }

    public class NewClass 
    {
        public int Add(int a, int b) => a + b;
        public int Add(int a, int b, int c) => a + b + c;
        public string Add(string a, string b) => a + b;
        //public int Add(int n, int m) => n + m; -> overloading does not work -> same signature, even thoug dif
        // name of parameters
        // different return type is also error
        public int Add(int a, ref int b) => a + b; // can differ in modifiers as well

    }
}
