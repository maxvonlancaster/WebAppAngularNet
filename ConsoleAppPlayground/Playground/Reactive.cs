using System;
using System.Collections.Generic;
using System.Reactive.Subjects;
using System.Text;

namespace ConsoleAppPlayground.Playground
{
    public class Reactive
    {
        public void ReactiveProgramming() 
        {
            // subscription 
            ISubject<StatusChange> statChange = new Subject<StatusChange>();
            statChange.Subscribe(sc => Console.WriteLine(sc.OrderStatus)); // lambda to do when changes in order

            statChange.OnNext(new StatusChange() { OrderId = 1, OrderStatus = "New"}) ;

        }
    }

    public class StatusChange 
    {
        public int OrderId { get; set; }
        public String OrderStatus { get; set; }
    }
}
