using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Swagger;

namespace FilterLists.Api.DependencyInjection.Extensions
{
    public static class ConfigureServicesCollection
    {
        public static void AddFilterListsApi(this IServiceCollection services)
        {
            services.AddMvcCustom();
            services.AddApiVersioning();
            services.AddResponseCaching();
            services.AddMemoryCache();
            services.AddSwaggerGenCustom();
            Microsoft.ApplicationInsights.Extensibility.Implementation.TelemetryDebugWriter.IsTracingDisabled = true;
        }

        private static void AddMvcCustom(this IServiceCollection services)
        {
            services.AddMvc(options =>
                {
                    options.CacheProfiles.Add("Long-Lived",
                        new CacheProfile
                        {
                            Duration = 86400
                        });
                })
                .AddJsonOptions(options =>
                {
                    options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                });
        }

        private static void AddSwaggerGenCustom(this IServiceCollection services)
        {
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
    }
}