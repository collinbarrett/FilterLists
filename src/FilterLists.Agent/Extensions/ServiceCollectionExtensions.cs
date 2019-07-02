using FilterLists.Agent.AppSettings;
using FilterLists.Agent.Core.Interfaces;
using FilterLists.Agent.Infrastructure.Clients;
using FilterLists.Agent.Infrastructure.Repositories;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Octokit;

namespace FilterLists.Agent.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterAgentServices(this IServiceCollection services)
        {
            services.AddConfiguration();
            services.AddLogging(b =>
            {
                b.AddConsole();
                var appInsightsKey = b.Services.BuildServiceProvider().GetService<IOptions<ApplicationInsights>>().Value
                    .InstrumentationKey;
                b.AddApplicationInsights(appInsightsKey);
            });
            services.AddMediatR(typeof(Program).Assembly);
            services.AddHttpClient<AgentHttpClient>();
            services.AddSingleton<IFilterListsApiClient, FilterListsApiClient>();
            services.AddSingleton<IGitHubClient>(s =>
            {
                var gitHubConfig = s.GetService<GitHub>();
                var client = new GitHubClient(new ProductHeaderValue(gitHubConfig.ProductHeaderValue))
                {
                    Credentials = new Credentials(gitHubConfig.OauthToken)
                };
                return client;
            });
            services.AddTransient<IListInfoRepository, ListInfoRepository>();
            services.AddTransient<IUrlRepository, UrlRepository>();
        }

        private static void AddConfiguration(this IServiceCollection services)
        {
            var config = new ConfigurationBuilder()
                .AddEnvironmentVariables()
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            services.Configure<ApplicationInsights>(config.GetSection(nameof(ApplicationInsights)));
            services.Configure<ConnectionStrings>(config.GetSection(nameof(ConnectionStrings)));
            services.Configure<GitHub>(config.GetSection(nameof(GitHub)));
        }
    }
}