using FilterLists.Agent.AppSettings;
using FilterLists.Agent.Core.Interfaces;
using FilterLists.Agent.Infrastructure.Clients;
using FilterLists.Agent.Infrastructure.Repositories;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace FilterLists.Agent.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterAgentServices(this IServiceCollection services)
        {
            services.AddConfiguration();
            services.AddLoggingCustom();
            services.AddMediatR(typeof(Program).Assembly);
            services.AddHttpClient<AgentHttpClient>();
            services.AddSingleton<IFilterListsApiClient, FilterListsApiClient>();
            services.AddSingleton<IAgentGitHubClient, AgentGitHubClient>();
            services.AddTransient<IListInfoRepository, ListInfoRepository>();
            services.AddTransient<IUrlRepository, UrlRepository>();
        }

        private static void AddConfiguration(this IServiceCollection services)
        {
            var config = new ConfigurationBuilder()
                .AddEnvironmentVariables()
                .AddJsonFile("appsettings.json", true, true)
#if DEBUG
                .AddJsonFile("appsettings.Development.json", true, true)
#endif
                .Build();
            services.Configure<ApplicationInsights>(config.GetSection(nameof(ApplicationInsights)));
            services.Configure<ConnectionStrings>(config.GetSection(nameof(ConnectionStrings)));
            services.Configure<GitHub>(config.GetSection(nameof(GitHub)));
        }

        private static void AddLoggingCustom(this IServiceCollection services)
        {
            services.AddLogging(b =>
            {
                b.AddConsole();
                var appInsightsConfig = b.Services.BuildServiceProvider().GetService<IOptions<ApplicationInsights>>();
                b.AddApplicationInsights(appInsightsConfig.Value.InstrumentationKey);
            });
        }
    }
}