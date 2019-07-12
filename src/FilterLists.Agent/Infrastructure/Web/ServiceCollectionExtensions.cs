using System;
using System.Net;
using FilterLists.Agent.Core.List;
using Microsoft.Extensions.DependencyInjection;
using Polly;

namespace FilterLists.Agent.Infrastructure.Web
{
    public static class ServiceCollectionExtensions
    {
        public static void AddListRepository(this IServiceCollection services)
        {
            services.AddHttpClient<IListRepository, ListRepository>().AddTransientHttpErrorPolicy(b =>
                b.OrResult(r => r.StatusCode == HttpStatusCode.TooManyRequests)
                    .WaitAndRetryAsync(5, i => i * TimeSpan.FromSeconds(3)));
        }
    }
}