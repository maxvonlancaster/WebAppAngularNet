using Autofac;
using ConsoleAppPlayground.Features;
using ConsoleAppPlayground.Js;
using ConsoleAppPlayground.Ml;
using ConsoleAppPlayground.Parallelism;
using ConsoleAppPlayground.Playground;
using System;

namespace ConsoleAppPlayground
{
    class Program
    {
        private static IContainer _container;

        static void Main(string[] args)
        {
            _container = AutofacInit.Init();

            var service = new Reactive();
            service.Main();

            var serviceDi = _container.Resolve<IMlService>();
            serviceDi.Main();
        }
    }
}
