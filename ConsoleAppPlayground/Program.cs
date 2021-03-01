using ConsoleAppPlayground.Features;
using ConsoleAppPlayground.Js;
using ConsoleAppPlayground.Parallelism;
using ConsoleAppPlayground.Playground;
using System;

namespace ConsoleAppPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new Reactive();
            service.Main();
        }
    }
}
