using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Nagarro.BookReading.Application.Interfaces;
using Nagarro.BookReading.Application.Services;
using Nagarro.BookReading.Core.Configuration;
using Nagarro.BookReading.Core.Repositories;
using Nagarro.BookReading.Core.Repositories.Base;
using Nagarro.BookReading.Infrastructure.Data;
using Nagarro.BookReading.Infrastructure.Repository;
using Nagarro.BookReading.Infrastructure.Repository.Base;
using Nagarro.BookReading.Web.Interfaces;
using Nagarro.BookReading.Web.Services;

namespace Nagarro.BookReading.Web
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
            ConfigureBookReadingEventServices(services); 
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //else
            //{
            //    app.UseExceptionHandler("/Error");
            //    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            //    app.UseHsts();
            //}
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
        public void ConfigureBookReadingEventServices(IServiceCollection services)
        {

            //Core Layer DI
            services.Configure<ConfigurationSettings>(Configuration);


            //Infrastructure Layer DI
            ConfigureDatabases(services);
            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<EventContext>();

            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequiredLength = 5;
                options.Password.RequiredUniqueChars = 1;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
            });

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IEventRepository, EventRepository>();
            services.AddScoped<IAccountRepository, AccountRepository>();

            //Application Layer DI
            services.AddScoped<IEventService, EventService>();
            services.AddScoped<IAccountService, AccountService>();

            //Web Layer DI
            services.AddAutoMapper(typeof(Startup)); // Add AutoMapper
            services.AddScoped<IIndexPageService, IndexPageService>();
            services.AddScoped<IEventPageService, EventPageService>();
            services.AddScoped<IAccountPageService, AccountPageService>();

            //Miscellaneous
            services.AddRazorPages();
        }
        public void ConfigureDatabases(IServiceCollection services)
        {
            //// use database
            services.AddDbContext<EventContext>(c =>
                c.UseSqlServer(Configuration.GetConnectionString("EventDatabase")));
        }
    }
}
