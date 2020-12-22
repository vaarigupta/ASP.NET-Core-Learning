using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Nagarro.BookReading.Infrastructure.Data;
using System;

namespace Nagarro.BookReading.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            SeedDataBase(host);
            host.Run();
        }

        public static IWebHostBuilder CreateHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
               .UseStartup<Startup>();

        private static void SeedDataBase(IWebHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var loggerFactory = services.GetRequiredService<ILoggerFactory>();

                try
                {
                    var eventContext = services.GetRequiredService<EventContext>();
                    EventContextSeed.SeedAsync(eventContext, loggerFactory).Wait();
                }
                catch (Exception exception)
                {
                    var logger = loggerFactory.CreateLogger<Program>();
                    logger.LogError(exception, "An error occurred seeding the DB.");
                }
            }
        }

    }
}
