using Autofac;
using ConsoleAppPlayground.Advancement.Db;
using ConsoleAppPlayground.Advancement.Db.Repositories;
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

            var serviceDi = _container.Resolve<IEfRepository>();
            var repo = _container.Resolve<IEfRepository>();
            serviceDi.Seed();
        }
    }
}
