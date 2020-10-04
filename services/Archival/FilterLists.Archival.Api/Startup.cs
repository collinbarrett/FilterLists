using FilterLists.Archival.Application;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FilterLists.Archival.Api
{
    internal class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting(o => o.LowercaseUrls = true);
            services.AddControllers()
                .AddJsonOptions(o => o.JsonSerializerOptions.IgnoreNullValues = true);
            services.AddSwaggerGen();
            services.AddApplicationServices(Configuration);
        }

        public static void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseApplication();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseEndpoints(e => e.MapControllers());
            app.UseSwagger();
        }
    }
}
