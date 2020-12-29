using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppPlayground.Features
{
    public class Delegates
    {
        public delegate int Calc(int x, int y, string s); // declaring delegate

        public delegate void Handler(string s);
        public event Handler MyEvent;

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
            calc1 += Add; // not one methos is possib, but an invocation list;
            calc1 -= Add; // substract from inv. list
            calc1.Invoke(1, 2, "Hi Mark "); // invoking using invoke();
            UseDelegate(calc1); // delegates can be params of the methopd;

            // Anonymous method
            Calc handler = delegate (int i, int j,string s) 
            {
                return i + 2 * j; 
            };

            // Lambda
            Calc op = (x, y, s) => x + y; // easy repres. of anonymous methods
            UseDelegate((x, y, s) => x + y); // can be used as parameters
            Calc op1 = (x, y, s) => Add(x, y, s); // can call another method

            // Events
            Handler handler1;
            handler1 = ShowMessage;
            MyEvent += handler1;
            MyEvent.Invoke("hello");

            // Action, Predicate, Func


        }

        public int Add(int x, int y, string s)  { Console.WriteLine(s + "Add"); return x + y; }
        public int Mult(int x, int y, string s) { Console.WriteLine(s + "Mult"); return x * y; }
        public int Subst(int x, int y, string s) { Console.WriteLine(s + "Subst"); return x - y; }
        public void UseDelegate(Calc calc) { calc?.Invoke(1, 1, "UseDelegate"); }
        public void ShowMessage(string s) { Console.WriteLine("Event happened: " + s); }
    }
}
