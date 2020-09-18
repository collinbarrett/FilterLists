using System;
using Microsoft.Extensions.DependencyInjection;
using Polly;

namespace FilterLists.Archival.Infrastructure.Clients
{
    internal static class ConfigurationExtensions
    {
        public static void AddClients(this IServiceCollection services)
        {
            services.AddHttpClient<IFileClient, FileClient>()
                .AddTransientHttpErrorPolicy(b => b.WaitAndRetryAsync(new[]
                {
                    TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(5), TimeSpan.FromSeconds(10)
                }));
        }
    }
}
