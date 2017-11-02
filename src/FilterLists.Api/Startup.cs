using FilterLists.Api.DependencyInjection.Extensions;
using FilterLists.Services.DependencyInjection.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FilterLists.Api
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
            services.AddFilterListsServices(Configuration);
            services.AddFilterListsApi();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
            });

            app.UseResponseCaching();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/v1/swagger.json", "FilterLists API V1");
                c.RoutePrefix = "docs";
            });

            app.UseStaticFiles();

            app.UseMvc(routes => { routes.MapRoute("default", "v{version:apiVersion}/{controller=Default}/{action=Get}/{id?}"); });
        }
    }
}