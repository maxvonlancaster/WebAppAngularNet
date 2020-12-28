using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppPlayground.Features
{
    public class SwitchCase
    {
        public void Main() 
        {
            var rand = new Random();
            int i = rand.Next(1, 3);
            switch (i) 
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                default:
                    Console.WriteLine("Three");
                    break;
            }
        }
    }
}
