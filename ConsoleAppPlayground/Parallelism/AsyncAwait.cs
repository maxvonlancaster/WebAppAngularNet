using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppPlayground.Parallelism
{
    public class AsyncAwait
    {
        public void Main() 
        {
            FirstMethod();
            for (int i = 0; i < 60; i++) 
            {
                Thread.Sleep(1000);
                Console.WriteLine("Main");
            }
        }

        public async Task<int> FirstMethod() 
        {
            Task<string> task = SecondMethod();
            for (int i = 0; i < 25; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("First");
            }

            Console.WriteLine("First Method is done");
            string s = await task;
            return 1;
        }

        public async Task<string> SecondMethod() 
        {
            Task task = ThirdMethod();

            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Second");
            }

            await task;

            Console.WriteLine("Second Method is done");
            return "";
        }

        public async Task ThirdMethod()
        {
            await Task.Run(() => 
            {
                for (int i = 0; i < 20; i++)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("Third");
                }
            });
        }
    }
}
