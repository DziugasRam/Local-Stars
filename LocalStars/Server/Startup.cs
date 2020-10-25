using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
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
            services.AddControllers();

            Startup.ConfigureServicesStatic(services, Configuration.GetConnectionString("DefaultConnection"), false);
        }

        public static void ConfigureServicesStatic(IServiceCollection services, string connectionString, bool addControllers)
        {
            services.AddDbContext<DataContext>(options => options.UseLazyLoadingProxies().UseMySql(connectionString));
            services.AddTransient<BuyerProvider>();
            services.AddTransient<ProductProvider>();
            services.AddTransient<SellerProvider>();
            if (addControllers)
            {
                services.AddTransient<BuyerController>();
                services.AddTransient<ProductController>();
                services.AddTransient<SellerController>();
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

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
