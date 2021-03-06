using Autofac;
using Autofac.Extensions.DependencyInjection;
using ConsoleAppPlayground.Advancement.Db;
using ConsoleAppPlayground.Ml;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
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

            builder.RegisterType<EfRepository>()
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();

            var jsCode = File.ReadAllText("./../../../appsettings.json");

            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();

            var services = new ServiceCollection();

            services.Configure<Settings>(options => configuration.GetSection("Settings").Bind(options));

            builder.Register(c =>
            {
                var opt = new DbContextOptionsBuilder<ProductsContext>();
                opt.UseSqlServer(configuration.GetConnectionString("Products"));
                return new ProductsContext(opt.Options);
            }).InstancePerLifetimeScope();

            builder.Populate(services);

            return builder.Build();
        }
    }
}
