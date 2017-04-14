using FilterLists.Services.Contracts;
using FilterLists.Services.Implementations;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace FilterLists.Services.DependencyInjection.Extensions
{
    public static class ConfigureServicesCollection
    {
        public static void AddFilterListsServices(this IServiceCollection services)
        {
            services.TryAddScoped<IListService, ListService>();
        }
    }
}