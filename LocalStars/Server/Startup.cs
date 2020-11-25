using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Models;
using Server.Controllers;
using Server.Providers;

namespace Server
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
            services.AddCors();
            services.AddControllers(o => o.Filters.Add(new AuthorizeFilter()));

            Startup.ConfigureServicesStatic(services, Configuration.GetConnectionString("DefaultConnection"), false);
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(o =>
                {
                    //TODO: check with non localhost domains
                    o.Cookie.Domain = "localhost";
                    o.Cookie.SameSite = Microsoft.AspNetCore.Http.SameSiteMode.None;
                });//TODO: login path
        }

        public static void ConfigureServicesStatic(IServiceCollection services, string connectionString, bool addControllers)
        {
            services.AddDbContext<DataContext>(options => options.UseLazyLoadingProxies().UseMySql(connectionString));
            services.AddTransient(services => new Lazy<BuyerProvider>(services.GetService<BuyerProvider>()));
            services.AddTransient(services => new Lazy<ProductProvider>(services.GetService<ProductProvider>()));
            services.AddTransient(services => new Lazy<SellerProvider>(services.GetService<SellerProvider>()));
            services.AddTransient<UserProvider>();
            if (addControllers)
            {
                services.AddTransient<BuyerController>();
                services.AddTransient<ProductController>();
                services.AddTransient<SellerController>();
                services.AddTransient<UserController>();
            }
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseCors(builder =>
            {
                builder
                .AllowCredentials()
                // TODO: add to configuration file, move db connection to secrets
                .WithOrigins("http://localhost:3000")
                .AllowAnyMethod()
                .WithHeaders("Content-Type");
            });

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
