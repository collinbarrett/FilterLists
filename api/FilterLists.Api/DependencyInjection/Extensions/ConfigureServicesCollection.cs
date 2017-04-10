using Microsoft.Extensions.DependencyInjection;

namespace FilterLists.Api.DependencyInjection.Extensions
{
    public static class ConfigureServicesCollection
    {
        // ReSharper disable once UnusedMethodReturnValue.Global
        public static IServiceCollection RegisterFilterListsApi(this IServiceCollection services)
        {
            services.AddMvc();
            return services;
        }
    }
}