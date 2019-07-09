using FilterLists.Agent.AppSettings;
using FilterLists.Agent.Core.ListInfo;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using RestSharp;

namespace FilterLists.Agent.Infrastructure.FilterListsApi
{
    public static class ServiceCollectionExtensions
    {
        public static void AddFilterListsApiResources(this IServiceCollection services)
        {
            services.AddSingleton<IRestClient, RestClient>(b =>
            {
                var filterListsApiSettings = b.GetService<IOptions<FilterListsApiSettings>>().Value;
                return new RestClient(filterListsApiSettings.BaseUrl) {UserAgent = "FilterLists.Agent"};
            });
            services.AddTransient<IListInfoRepository, ListInfoRepository>();
        }
    }
}