using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace FilterLists.Api.DependencyInjection.Extensions
{
    public static class ConfigureServicesCollection
    {
        public static IServiceCollection RegisterFilterListsApi(this IServiceCollection services)
        {
            services.AddMvc()
                .AddJsonOptions(options =>
                {
                    //TODO: determine why null values still get returned
                    options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
                });
            return services;
        }
    }
}