using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Nagarro.BookReadingEvent.BusinessFacades;
using Nagarro.BookReadingEvent.Shared;
using Nagarro.BookReadingEvent.Shared.Functional.Entities;
using Nagarro.BookReadingEvent.Shared.Functional.IRepositories;
using Nagarro.BookReadingEvent.Shared.Functional.Repositories;

namespace Nagarro.BookReadingEvent
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // services.AddScoped<IEventFacade, EventManagerFacade>();
            //support of Identity
            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<EventContext>();

            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<IEventRepository, EventRepository>();
            services.AddDbContext<EventContext>(options => options.UseSqlServer(Configuration.GetConnectionString("EventDatabase")));
            
            services.AddControllersWithViews();
#if DEBUG
            services.AddRazorPages().AddRazorRuntimeCompilation();

#endif

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            //enabling the authentication
            app.UseAuthentication();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
