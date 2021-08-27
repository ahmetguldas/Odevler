using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Odevler.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Odevler
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
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        ////bu metot icerisinde middleware ler cagrilir. asp .net core mimarisinde tum middleware ler use adiyla baslar.
        ///middleware lerin tetiklenme sirasi onemlidir.
        ///
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) 
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles(); // wwwroot klasorune erisebilmek icin bu middleware cagrilmasi gereklidir.Standart eklenmis sekilde geldi.Ama bilinmesi onemli

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
            //endpoints.Map("example", async x =>
            //{
            //https:localhost/example  endpoint e gelen herhangi bir istek Controller dan ziyade direkt olarak buradaki fonksiyon tarafindan karsilanacaktir.
            //});

            //https://localhost:44307/image/2.jpg?w=100&h=100
                endpoints.Map("image/{imageName}", new ImageHandler().Handler(env.WebRootPath));

                
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
