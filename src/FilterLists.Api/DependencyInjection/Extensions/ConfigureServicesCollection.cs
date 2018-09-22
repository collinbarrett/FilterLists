using System;
using System.IO;
using Microsoft.ApplicationInsights.Extensibility.Implementation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
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
            services.ConfigureCookiePolicy();
            services.AddMemoryCache();
            services.AddResponseCaching();
            services.AddMvcCustom();
            services.AddRoutingCustom();
            services.AddApiVersioning();
            services.AddSwaggerGenCustom();
            TelemetryDebugWriter.IsTracingDisabled = true;
        }

        private static void ConfigureCookiePolicy(this IServiceCollection services) =>
            services.Configure<CookiePolicyOptions>(opts =>
            {
                opts.CheckConsentNeeded = context => true;
                opts.MinimumSameSitePolicy = SameSiteMode.None;
            });

        private static void AddMvcCustom(this IServiceCollection services) =>
            services.AddMvc()
                    .SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                    .AddJsonOptions(opts =>
                    {
                        opts.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
                        opts.SerializerSettings.ContractResolver = new SkipEmptyContractResolver();
                    });

        private static void AddRoutingCustom(this IServiceCollection services) =>
            services.AddRouting(opts => opts.LowercaseUrls = true);

        private static void AddSwaggerGenCustom(this IServiceCollection services) =>
            services.AddSwaggerGen(opts =>
            {
                opts.SwaggerDoc("v1",
                    new Info
                    {
                        Title = "FilterLists API",
                        Version = "v1",
                        Description =
                            "A REST-ish API for FilterLists, the independent, comprehensive directory of all public filter and hosts lists for advertisements, trackers, malware, and annoyances." +
                            Environment.NewLine +
                            " - {version} has to be specified manually (to \"1\") in Swagger playground below due to https://github.com/domaindrivendev/Swashbuckle.AspNetCore/issues/370",
                        Contact =
                            new Contact
                            {
                                Url = "https://github.com/collinbarrett/FilterLists/",
                                Name = "FilterLists - GitHub"
                            },
                        License = new License
                        {
                            Name = "MIT License",
                            Url = "https://github.com/collinbarrett/FilterLists/blob/master/LICENSE"
                        }
                    });
                opts.IncludeXmlComments(Path.Combine(PlatformServices.Default.Application.ApplicationBasePath,
                    "FilterLists.Api.xml"));
            });
    }
}