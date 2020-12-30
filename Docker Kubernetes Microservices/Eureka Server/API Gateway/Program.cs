

namespace API_Gateway
{
    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Ocelot.DependencyInjection;
    using Ocelot.Middleware;
    using Ocelot.Provider.Eureka;
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                .UseUrls("http://localhost:7000")
                .ConfigureAppConfiguration((hostingContext, config) =>
                {
                    config
                        .SetBasePath(hostingContext.HostingEnvironment.ContentRootPath)
                        .AddJsonFile("appsettings.json", true, true)
                        .AddJsonFile($"appsettings.{hostingContext.HostingEnvironment.EnvironmentName}.json", true,
                            true)
                        .AddJsonFile("ocelot.json", false, false)
                        .AddEnvironmentVariables();
                })
                .ConfigureServices(s =>
                {
                    s.AddOcelot()
                    //.AddTransientDefinedAggregator<FakeDefinedAggregator>() //for aggregates
                    .AddEureka();//.AddPolly();
                })
                .Configure(a =>
                {
                    a.UseOcelot().Wait();
                    a.UseDeveloperExceptionPage();

                })
                .Build();
        }
    }
}
