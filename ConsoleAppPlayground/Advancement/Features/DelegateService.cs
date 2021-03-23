using System;
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


        delegate void MessageNew(string s);
        delegate int AddNew(int x, int y);
        private void Messaging(string s, MessageNew del) { del(s); }
        public void AnonMethods() 
        {
            // anon methods used for creation of delegate exemplars
            MessageNew handler = delegate (string s)
            {
                Console.WriteLine(s);
            };

            // has access to outside var-s
            int i = 5;
            AddNew add = delegate (int x, int y)
            {
                return x + y + i;
            };

            //var del = delegate (string s) -> can not assign delegate to implicitly typed variable - ERROR
            //{
            //    Console.WriteLine(s);
            //};

            // anon method can be passed as a param:
            Messaging("hello", delegate(string s) { Console.WriteLine(s); });
        }


        delegate int OperLam(int x, int y);
        delegate int Squere(int x);
        delegate void HelloLam();
        delegate void Handler(ref int n);
        delegate int ChangeNum(int i);
        public void Lambdas() 
        {
            // lambda - simplified writting of anon method;
            // 
            OperLam operLam = (x, y) => x + y;
            OperLam operLam1 = (x, y) => { Console.WriteLine(""); return x + y; };
            //var lam = (x, y) => x + y; -> cannot assign lambda to implicitly typed variable
            Squere squere = x => x * x; // brackets in parameters can be ommitted if one param;
            HelloLam hello = () => Console.WriteLine("hello"); // empty brackets if no params;
            Handler handler = (ref int i) => i = i * 2; // type has to be put in brackets if ref ot out modifiers
            HelloLam hello1 = () => Show_M(); // lambdas can make other methods

            // lmbdas can be passed as params to methods:
            var nums = ChangeNumbers(new List<int>() { 1, 2, 3, 4 }, i => i + 10);
        }
        private static void Show_M() { Console.WriteLine("Show_M"); }
        private IEnumerable<int> ChangeNumbers(List<int> list, ChangeNum del) 
        {
            foreach (int i in list) { yield return del(i); }
        }



        public delegate void AccHandler(string messge);
        event AccHandler Notify;
        private event AccHandler _someEv;
        public event AccHandler SomeEv 
        {
            add 
            {
                _someEv += value; // with access modifiers add-remove we can control adding and deletion of hndlers
                Console.WriteLine($"{value.Method.Name} added");
            }
            remove 
            {
                _someEv -= value;
                Console.WriteLine($"{value.Method.Name} removed");
            }
        }
        public void Events() 
        {
            // events signal to the system tht something happened;
            // keyword event nd type of delegate that represents the event:
            AccHandler accHandler = s => Console.WriteLine(s);
            Notify += accHandler; // adding event handler to event
            Notify += Show_MN;
            Notify("event"); // we can call an event
            Notify?.Invoke("invoke"); // event can be null if no handler defined 
            Notify -= Show_MN; // can be removed
        }
        private void Show_MN(string s) { Console.WriteLine(s); }



        public void Coverity() 
        { 
        
        }


        public void DelegatesFuncActionPred() 
        {
            // Action - takes parameter and returns void
            Action<string> action = (string s) => { Console.WriteLine(s); };
            action("Hello");
            action = (s) => { Console.WriteLine(s); };
            Action<int, int> action1 = (int i, int j) => { Console.WriteLine(i + j); };

            // Predicate - takes parameter and returns bool
            Predicate<int> isPositive = delegate (int i) { return i > 0; };

            // Func - returns last parameter
            Func<int, int, string> func = AddToStr;
            Console.WriteLine(AddToStr(1, 2));

        }
        private string AddToStr(int i, int j) { return (i + j).ToString(); }

    }
}
