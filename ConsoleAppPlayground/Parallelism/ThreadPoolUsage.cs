using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleAppPlayground.Parallelism
{
    class ThreadPoolUsage
    {
        public void Main()
        {
            int nWorkerThreads;
            int nCompletionThreads;
            ThreadPool.GetMaxThreads(out nWorkerThreads, out nCompletionThreads);
            Console.WriteLine("Максимальное количество потоков: " + nWorkerThreads
                + "\nПотоков ввода-вывода доступно: " + nCompletionThreads);
            for (int i = 0; i < 5; i++)
                ThreadPool.QueueUserWorkItem(JobForAThread);
            Thread.Sleep(3000);

            Calc();

            Console.ReadLine();
        }

        public void JobForAThread(object state)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("цикл {0}, выполнение внутри потока из пула {1}",
                    i, Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(50);
            }
        }

        public int Calc() 
        {
            return 100*2;
        }
    }

}
