using FilterLists.Agent.Core.List;
using Microsoft.Extensions.DependencyInjection;

namespace FilterLists.Agent.Infrastructure.FilterListsApi
{
    public static class ServiceCollectionExtensions
    {
        public static void AddFilterListsApiResources(this IServiceCollection services)
        {
            services.AddSingleton<IFilterListsApiClient, FilterListsApiClient>();
            services.AddTransient<IListUrlRepository, ListUrlRepository>();
        }
    }
}