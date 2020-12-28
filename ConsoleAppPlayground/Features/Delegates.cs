using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppPlayground.Features
{
    public class Delegates
    {
        public delegate int Calc(int x, int y, string s); // declaring delegate

        public void Main()
        {
            Calc calc; // create variable of the delegate 
            var random = new Random();
            int i = random.Next(0, 2);
            switch (i) 
            {
                case 0:
                    calc = Add; // asign this variable an adress of the method 
                    break;
                case 1:
                    calc = Mult;
                    break;
                default:
                    calc = Subst;
                    break;
            }
            calc(4, 3, "Hello, "); //  call method
            Calc calc1 = new Calc(Mult); // Anothwer way to init -> using constructor
        }

        public int Add(int x, int y, string s)  { Console.WriteLine(s + "Add"); return x + y; }
        public int Mult(int x, int y, string s) { Console.WriteLine(s + "Mult"); return x * y; }
        public int Subst(int x, int y, string s) { Console.WriteLine(s + "Subst"); return x - y; }
    }
}
