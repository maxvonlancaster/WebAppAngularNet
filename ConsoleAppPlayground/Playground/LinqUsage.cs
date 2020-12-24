using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppPlayground.Playground
{
    public class LinqUsage
    {
        public void LinqQuerryable() 
        {
            List<string> ls = new List<string>() { "a", "b", "c", "ca", "ba", "d"};

            var quer = from s in ls
                       where s.Length == 2
                       select s;

            Console.WriteLine(quer.GetType());

            var enumeb = quer.AsEnumerable();

            var lis = quer.ToList();

        }
    }
}
