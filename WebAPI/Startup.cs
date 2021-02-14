using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.Entity_Framework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI
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
            services.AddSingleton<IAdminService, AdminManager>();
            services.AddSingleton<IAdminDAL, EfAdminDAL>();
            services.AddSingleton<IAuthorizedService, AuthorizedManager>();
            services.AddSingleton<IAuthorizedDAL, EfAuthorizedDAL>();
            services.AddSingleton<ICustomerRegistrationService, CustomerRegistrationManager>();
            services.AddSingleton<ICustomerRegistrationDAL, EfCustomerRegistrationDAL>();
            services.AddSingleton<IProductRegistrationService, ProductRegistrationManager>();
            services.AddSingleton<IProductRegistrationDAL, EfProductRegistrationDAL>();
            services.AddSingleton<IRegionService, RegionManager>();
            services.AddSingleton<IRegionDAL, EfRegionDAL>();
            services.AddSingleton<ISoldProductService, SoldProductManager>();
            services.AddSingleton<ISoldProductDAL, EfSoldProductDAL>();


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
