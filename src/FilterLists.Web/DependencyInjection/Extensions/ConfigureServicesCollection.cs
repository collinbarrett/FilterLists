using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace FilterLists.Web.DependencyInjection.Extensions
{
    public static class ConfigureServicesCollection
    {
        public static void AddFilterListsWeb(this IServiceCollection services)
        {
            services.AddMvcCustom();
            services.AddResponseCaching();
            services.AddMemoryCache();
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
            });
        }
    }
}