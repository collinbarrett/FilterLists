using FilterLists.Services.Contracts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace FilterLists.Services.DependencyInjection.Extensions
{
    public static class ConfigureServicesCollection
    {
        public static IServiceCollection AddFilterListsServices(this IServiceCollection services)
        {
            services.TryAddScoped<IListService, ListService>();
            return services;
        }
    }
}