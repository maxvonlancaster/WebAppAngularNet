using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace EWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }

    // To create angular app: ng new Angular
    // to run it: ng serve --o
    // to generate a component: ng g c component-name
    // to create service file inside shared folder: ng g s shared/presentation
    // to generate a class: ng g cl


    // TODO:
    // 1. Auth and authoris add 
    // 2. Angular multipage +
    // 3. Presentation streaming 
    // 4. File display (or download) 
    // 5. Tokens, jwt 
    // 6. Clear form on click 
    // 7. Look up auth in angular 
    // 8. 
}
