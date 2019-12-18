using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PlayBall.GroupManagement.Business.Services;
using PlayBall.GroupManagement.Business.Services.Impl;

namespace PlayBall.GroupManagement.Web
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddBusiness();

            //var containerBuilder = new ContainerBuilder();
            //containerBuilder.RegisterModule<AutofacModule>();
            //containerBuilder.Populate(services);
            //var container = containerBuilder.Build();
            //return new AutofacServiceProvider(container);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // ÅäÖÃ¾²Ì¬ÎÄ¼þ
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
