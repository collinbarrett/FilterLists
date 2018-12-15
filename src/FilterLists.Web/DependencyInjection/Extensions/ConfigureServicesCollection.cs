using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace FilterLists.Web.DependencyInjection.Extensions
{
    public static class ConfigureServicesCollection
    {
        public static void AddFilterListsWeb(this IServiceCollection services)
        {
            services.ConfigureCookiePolicy();
            services.AddMvcCustom();
        }

        private static void ConfigureCookiePolicy(this IServiceCollection services) =>
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

        private static void AddMvcCustom(this IServiceCollection services) =>
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
    }
}