using System.Net.Http;
using FilterLists.Agent.Core.Lists;
using FilterLists.Agent.Core.Urls;
using Microsoft.Extensions.DependencyInjection;

namespace FilterLists.Agent.Infrastructure.Web
{
    public static class ServiceCollectionExtensions
    {
        public static void AddWebServices(this IServiceCollection services)
        {
            services.AddHttpClient<IListRepository, ListRepository>()
                .AddPolicyHandlerFromRegistry("waitAndRetryTooManyRequests");
            services.AddHttpClient<IUrlValidator, UrlValidator>().ConfigureHttpMessageHandlerBuilder(b =>
            {
                b.PrimaryHandler = new HttpClientHandler {AllowAutoRedirect = false};
                b.Build();
            }).AddPolicyHandlerFromRegistry("waitAndRetryTooManyRequests");
        }
    }
}