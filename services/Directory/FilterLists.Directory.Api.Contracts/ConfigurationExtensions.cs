using FilterLists.Directory.Api.Contracts.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Polly;
using Refit;

namespace FilterLists.Directory.Api.Contracts
{
    public static class ConfigurationExtensions
    {
        public static void AddDirectoryApiClient(this IServiceCollection services, IConfiguration configuration)
        {
            // TODO: use SystemTextJsonContentSerializer() once less feature-limited
            services.AddRefitClient<IDirectoryApi>()
                .ConfigureHttpClient(c =>
                {
                    var host = configuration.GetSection(ApiOptions.Key).Get<ApiOptions>().DirectoryHost;
                    c.BaseAddress = new UriBuilder("http", host).Uri;
                })
                .AddTransientHttpErrorPolicy(b =>
                    b.WaitAndRetryAsync(new[]
                    {
                        TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(5), TimeSpan.FromSeconds(10)
                    }));
        }
    }
}
