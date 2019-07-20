using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using ScoringDepthReact.Models;

namespace ScoringDepthReact
{
    public class Program
    {
        public static void Main(string[] args)
        {
           
            var host = CreateWebHostBuilder(args).Build();

            //get access to services from DI container (to get AppDbContext)
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<AppDbContext>();
                    DbInitializer.Seed(context);
                }
                catch (Exception e)
                {
                    //add logging later
                    Console.WriteLine(e);
                }
            }

            host.Run();
        }

        //CreateDefaultBuilder reads appsettings.json (and gets sql connection string)
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
