using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace ConsoleAppPlayground.Parallelism
{
    public class ActionBlockUsage
    {
        // This class can be thought of logically as a buffer for data to be processed combined with 
        // tasks for processing that data, with the “dataflow block” managing both. In its most basic 
        // usage, we can instantiate an ActionBlock and “post” data to it; the delegate provided at 
        // the ActionBlock’s construction will be executed asynchronously for every piece of data posted.
        public void Main() 
        {
            SimpleActionBlock();
        }

        public void SimpleActionBlock() 
        {
            var downloader = new ActionBlock<string>(async url => 
            {
                HttpClient httpClient = new HttpClient();
                var data = await httpClient.GetStringAsync(url);
                Console.WriteLine(data);
            }, new ExecutionDataflowBlockOptions { MaxDegreeOfParallelism = 5});

            downloader.Post("https://riptutorial.com/csharp/example/10604/actionblock-t-");
            downloader.Complete();
        }
    }
}
