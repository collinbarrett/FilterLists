using Microsoft.Extensions.DependencyInjection;

namespace FilterLists.Api.DependencyInjection.Extensions
{
    public static class ConfigureServicesCollection
    {
        public static IServiceCollection RegisterFilterListsApi(this IServiceCollection services)
        {
            services.AddMvc();
            return services;
        }
    }
}