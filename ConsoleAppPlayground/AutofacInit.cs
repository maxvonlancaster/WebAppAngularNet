using Autofac;
using ConsoleAppPlayground.Ml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPlayground
{
    public class AutofacInit
    {
        public static IContainer Init() 
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<MlService>()
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();

            return builder.Build();
        }
    }
}
