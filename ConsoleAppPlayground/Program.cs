using Autofac;
using ConsoleAppPlayground.Advancement.Db;
using ConsoleAppPlayground.Advancement.Db.Repositories;
using ConsoleAppPlayground.Advancement.Features;
using ConsoleAppPlayground.Advancement.Hacks;
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

            var service = new TypesService();
            service.Main();

            var serviceDi = _container.Resolve<AdoNetRepository>();
            serviceDi.Main();
            //serviceDi.Main();
            //var repo = _container.Resolve<IEfRepository>();
            //serviceDi.Seed();
        }

        // TODO:
        // 1. Ado net repository -> try
        // 2. Add visual repres 
        // 3. Unit tests 
        // 4. Integration tests 
        // 5. Add new features 
        // 6. Work with enum 

        // ALSO IDEAS TO WORK:
        // 1. Xamarin app
        // 2. Math app on react (calculate matrixes ets.)
        // 3. Learn C++ and F# 
    }
}
