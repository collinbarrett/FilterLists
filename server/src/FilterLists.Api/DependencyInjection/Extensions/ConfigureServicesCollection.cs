using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace FilterLists.Api.DependencyInjection.Extensions
{
    public static class ConfigureServicesCollection
    {
        public static void AddFilterListsApi(this IServiceCollection services)
        {
            services.ConfigureCookiePolicy();
            services.AddMemoryCache();
            services.AddResponseCaching();
            services.AddControllersCustom();
            services.AddRoutingCustom();
            services.AddApiVersioning();
        }

        private static void ConfigureCookiePolicy(this IServiceCollection services) =>
            services.Configure<CookiePolicyOptions>(opts =>
            {
                opts.CheckConsentNeeded = context => true;
                opts.MinimumSameSitePolicy = SameSiteMode.None;
            });

        private static void AddControllersCustom(this IServiceCollection services) =>
            services.AddControllers()
                    .SetCompatibilityVersion(CompatibilityVersion.Version_3_0)
                    .AddNewtonsoftJson(opts =>
                    {
                        opts.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
                        opts.SerializerSettings.ContractResolver = new SkipEmptyContractResolver();
                    });

        private static void AddRoutingCustom(this IServiceCollection services) =>
            services.AddRouting(opts => opts.LowercaseUrls = true);
    }
}