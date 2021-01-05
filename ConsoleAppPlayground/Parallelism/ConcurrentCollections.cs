using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppPlayground.Parallelism
{
    public class ConcurrentCollections
    {
        public void Main() 
        {
            SendingMessages();
        }

        // Usage of ConcurrentQueue
        public void ConcurrentQueueUsage() 
        {
            ConcurrentQueue<int> cq = new ConcurrentQueue<int>();
            for (int i = 0; i < 10000; i++) 
            {
                cq.Enqueue(i);
            }

            int outerSum = 0;
            Action action = () =>
            {
                int localSum = 0;
                int localValue;
                while (cq.TryDequeue(out localValue)) localSum += localValue;
                Console.WriteLine("Thread: {0}, sum: {1}", Thread.CurrentThread.Name, localSum);
                Interlocked.Add(ref outerSum, localSum);
            };
            Parallel.Invoke(action, action, action, action);
            Console.WriteLine("Total sum: {0}", outerSum);
        }

        // Sending messages between threads 
        public void SendingMessages() 
        {
            ConcurrentQueue<string> cq = new ConcurrentQueue<string>();
            Action sender = () =>
            {
                for (int i = 0; i < 100; i++) 
                {
                    string message = "Message number " + i.ToString();
                    cq.Enqueue(message);
                    Thread.Sleep(100);
                }
                cq.Enqueue("EOL");
            };

            Action receiver = () =>
            {
                string message = "";
                while (message != "EOL") 
                {
                    cq.TryDequeue(out message);
                    Console.WriteLine(message);
                    Thread.Sleep(100);
                }
            };
            Parallel.Invoke(sender, receiver);

        }
    }
}
