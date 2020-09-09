using FilterLists.Archival.Application;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FilterLists.Archival.Api
{
    public class Startup
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddApplicationServices();
        }

        public static void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();
        }
    }
}