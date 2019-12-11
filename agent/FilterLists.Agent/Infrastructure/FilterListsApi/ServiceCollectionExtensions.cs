using FilterLists.Agent.Core.Lists;
using FilterLists.Agent.Core.Urls;
using Microsoft.Extensions.DependencyInjection;

namespace FilterLists.Agent.Infrastructure.FilterListsApi
{
    public static class ServiceCollectionExtensions
    {
        public static void AddFilterListsApiServices(this IServiceCollection services)
        {
            services.AddSingleton<IFilterListsApiClient, FilterListsApiClient>();
            services.AddTransient<IListViewUrlRepository, ListViewUrlRepository>();
            services.AddTransient<IEntityUrlRepository, EntityUrlRepository>();
        }
    }
}