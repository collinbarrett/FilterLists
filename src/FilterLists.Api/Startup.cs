using System.IO;
using FilterLists.Api.DependencyInjection.Extensions;
using FilterLists.Services.DependencyInjection.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;
using Swashbuckle.AspNetCore.Swagger;

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
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new Info
                    {
                        Title = "FilterLists API",
                        Version = "v1",
                        Description =
                            "FilterLists is the independent and comprehensive directory of all public filter and hosts lists for advertisements, trackers, malware, and annoyances.",
                        Contact = new Contact {Url = "https://filterlists.com/contact/"},
                        License = new License
                        {
                            Name = "Use under GPL-3.0",
                            Url = "https://github.com/collinbarrett/FilterLists/blob/master/LICENSE"
                        }
                    });
                c.IncludeXmlComments(Path.Combine(PlatformServices.Default.Application.ApplicationBasePath,
                    "FilterLists.Api.xml"));
            });
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
            });

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "FilterLists API V1");
            });

            app.UseMvc();
        }
    }
}