using System;
using FilterLists.SharedKernel.Apis.Clients.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Refit;

namespace FilterLists.SharedKernel.Apis.Clients
{
    public static class ConfigurationExtensions
    {
        public static void AddApiClients(this IServiceCollection services, IConfiguration configuration)
        {
            // TODO: add Polly for resiliency
            // TODO: use SystemTextJsonContentSerializer() once less feature-limited
            services.AddRefitClient<IDirectoryApi>()
                .ConfigureHttpClient(c =>
                {
                    var host = configuration.GetSection(ApiOptions.Key).Get<ApiOptions>().DirectoryHost;
                    c.BaseAddress = new UriBuilder("http", host).Uri;
                });
        }
    }
}
