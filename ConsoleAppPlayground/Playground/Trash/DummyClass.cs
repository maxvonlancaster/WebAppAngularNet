using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPlayground.Playground.Trash
{
    public class DummyClass
    {
        public int Add(int x, int y) 
        {
            return x + y;
        }

        public int Multiply(int x, int y) 
        {
            return x * y;
        }

        public int Factorial(int n) 
        {
            int res = 1;
            for (int i = 1; i <= n; i++) 
            {
                res = res * i;
            }
            return res;
        }
    }
}
