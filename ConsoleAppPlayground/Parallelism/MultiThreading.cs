using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppPlayground.Parallelism
{
    public class MultiThreading
    {
        public void Main() 
        {
            var locking = new Structure() { id = 1};
            //lock (locking)  --> structure is not a reference type as required by locking 
            //{
            
            //}
        }
    }

    public struct Structure 
    {
        public int id;
    }
}
