﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPlayground.Advancement.Features
{
    // here will be delegates, events, lambdas, etc
    public class DelegateService
    {
        public void Main() 
        {

        }

        delegate int Oper(int x, int y); // keyword, and signature
        delegate void Message();
        delegate T OperGen<T>(T i, T j);
        public void Delegates() 
        {
            // delegates - objects that point to methods 
            // with the help of delegates we can call these methods 
            Oper oper; // create variable of delegate
            var random = new Random();
            int i = random.Next(3);
            switch (i) 
            {
                case 0:
                    oper = Add; // assign adress ofa method to the delegte
                    break;
                case 1:
                    oper = Substract;
                    break;
                case 2:
                    oper = Mult;
                    break;
                default:
                    oper = Math.Min; // delegtes can point to methods outside the class
                    break;
            }
            int r = oper(10, 4); // call method
            Console.WriteLine(r);

            Oper oper1 = new Oper(Mult); // can also create method with constructor, that receives the method of signature
            // ref and out also to be taken into account
            //oper = MultRef; - ERROR

            // delegate can point to multiple methods - invocation list
            Message mes;
            mes = Hello;
            mes += HelloNext; // in reality new delegte is created, that receives copy of the old one
            mes += Hello; // this method will be called two times
            mes();
            mes -= Hello; // deleting from incok list
            // if no method while deleting - no error;

            Message mes1 = Hello;
            Message mes2 = HelloNext;
            Message mes3 = mes1 + mes2; // unification of delegates - incok. lists added

            mes3.Invoke(); // also calling the delegate;
            oper1.Invoke(3, 5);
            // if no methods in list of delegate - Invoke will throw error;
            oper1?.Invoke(10, 10); // this way no exception will be thrown
            // if delegate returns value and a couple a celled, the last one will return the final value;

            // delegates can be parameters in methods:
            ShowMessage(mes3);

            // delegates can be generic
            OperGen<int> operGen = Mult;
            int k = Mult(2, 2);
        }
        private int Add(int x, int y) { return x + y; }
        private int Substract(int x, int y) { return x - y; }
        private int Mult(int x, int y) { return x * y; }
        private int MultRef(int x, ref int y) { y = x * y; return y; }
        private void Hello() { Console.WriteLine("Hello"); }
        private void HelloNext() { Console.WriteLine("Hello next"); }
        private void ShowMessage(Message _del) { _del.Invoke(); }


        public void DelegatesUsage() 
        { 
        
        }

        public void AnonMethods() 
        { 
        
        }

        public void Lambdas() 
        { 
        
        }

        public void Events() 
        { 
        
        }

        public void Coverity() 
        { 
        
        }

        public void DelegatesFuncActionPred() 
        { 
        
        }

    }
}
