using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoolRatings.Helpers;
using CoolRatings.Interfaces;
using CoolRatings.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CoolRatings
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextPool<DBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("ShowConnectionString")));
            services.AddControllers();
            services.AddScoped<IShowInterface, ShowHelper>();
            services.AddScoped<IRatingInterface, RatingHelper>();
        }
       
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }



            app.UseRouting();
            app.UseCors(option =>
                            option.AllowAnyOrigin()
                           .AllowAnyMethod()
                           .AllowAnyHeader());
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
