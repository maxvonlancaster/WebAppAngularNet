using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleAppPlayground.Parallelism
{
    public class MultiThreading
    {
        public void Main() 
        {
            var locking = new Structure() { id = 1};
            //lock (locking)  --> structure is not a reference type as required by locking 
            //{ }
            
        }


        public void TwoParallelThreads() 
        {
            Thread threadOne = new Thread(MethodOne);
            Thread threadTwo = new Thread(MethodTwo);
            threadOne.Start();
            threadTwo.Start();
        }


        public void MethodOne() 
        {
            Random random = new Random();
            for (int i = 0; i < 100; i++) 
            {
                Thread.Sleep(random.Next(0, 10));
                Console.WriteLine("MethodOne: " + i);
            }
        }


        public void MethodTwo() 
        {
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(random.Next(0, 10)); 
                Console.WriteLine("MethodTwo: " + i);
            }
        }


    }

    public struct Structure 
    {
        public int id;
    }
}
