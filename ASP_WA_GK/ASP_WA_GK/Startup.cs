using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_WA_GK.DbModels;
using ASP_WA_GK.Repositories;
using ASP_WA_GK.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ASP_WA_GK
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        private void SetupDbContext(IServiceCollection services)
        {
            var connString = Configuration.GetConnectionString("pma");

            services.AddDbContext<pma_pmfContext>(options => options.UseSqlServer(connString));
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().AddNewtonsoftJson();
            services.AddControllersWithViews();

            services.AddScoped<CourseRepository>();
            services.AddScoped<CourseService>();

            SetupDbContext(services);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
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
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "PMF_Odjeli",
                    pattern: "PMFST/Odjeli",
                    defaults: new { controller = "PMF",  action = "Odjeli"});

                endpoints.MapControllerRoute(
                    name: "PMF_Kolegiji",
                    pattern: "PMFST/Courses",
                    defaults: new { controller = "Courses", action = "Courses" });
            });
        }
    }
}
