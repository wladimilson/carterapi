using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Carter;

namespace CarterAPI
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCarter();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();

            app.UseSwaggerUI(opt =>
            {
                opt.RoutePrefix = "openapi/ui";
                opt.SwaggerEndpoint("/openapi", "Carter OpenAPI Sample");
            });

            app.UseEndpoints(endpoints => endpoints.MapCarter());
        }
    }
}
