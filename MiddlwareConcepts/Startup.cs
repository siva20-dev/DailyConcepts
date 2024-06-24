using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlwareConcepts
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
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MiddlwareConcepts", Version = "v1" });
            });
            services.AddTransient<CustomMiddleware>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync("Hello from Run");
            });

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello from Use-1 1 \n");

                await next();

                await context.Response.WriteAsync("Hello from Use-1 2 \n");
            });

            app.UseMiddleware<CustomMiddleware>();

            app.Map("/Nitish", CustomCode);

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello from Use-2 1 \n");

                await next();

                await context.Response.WriteAsync("Hello from Use2- 2 \n");
            });

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Request Complete \n");
            });

            app.Run(async context =>
            {
                await context.Response.WriteAsync("Hello from Run2 \n");
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MiddlwareConcepts v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private void CustomCode(IApplicationBuilder app)
        {
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello from Nitish \n");
            });
        }
    }
}
