using System;
using System.Net;
using System.Net.Http;
using FilterLists.Agent.Core.Lists;
using FilterLists.Agent.Core.Urls;
using Microsoft.Extensions.DependencyInjection;
using Polly;

namespace FilterLists.Agent.Infrastructure.Web
{
    public static class ServiceCollectionExtensions
    {
        public static void AddWebResources(this IServiceCollection services)
        {
            services.AddHttpClient<IListRepository, ListRepository>().AddTransientHttpErrorPolicy(b =>
                b.OrResult(r => r.StatusCode == HttpStatusCode.TooManyRequests)
                    .WaitAndRetryAsync(5, i => i * TimeSpan.FromSeconds(3)));
            services.AddHttpClient<IUrlValidator, UrlValidator>()
                .ConfigureHttpMessageHandlerBuilder(b =>
                {
                    b.PrimaryHandler = new HttpClientHandler {AllowAutoRedirect = false};
                    b.Build();
                })
                .AddTransientHttpErrorPolicy(b =>
                    b.OrResult(r => r.StatusCode == HttpStatusCode.TooManyRequests)
                        .WaitAndRetryAsync(5, i => i * TimeSpan.FromSeconds(3)));
        }
    }
}