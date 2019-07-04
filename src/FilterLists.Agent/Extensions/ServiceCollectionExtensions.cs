using System;
using System.Net.Http;
using CommandLine;
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
            services.AddTransient<Parser>();
            services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());
            services.AddAgentHttpClient();
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
            services.ConfigureCustom<ApplicationInsightsSettings>(config);
            services.ConfigureCustom<ConnectionStringsSettings>(config);
            services.ConfigureCustom<GitHubSettings>(config);
        }

        private static void ConfigureCustom<TSettings>(this IServiceCollection services, IConfiguration configuration)
            where TSettings : class
        {
            services.Configure<TSettings>(configuration.GetSection(typeof(TSettings).Name.RemoveSettingsSuffix()));
        }

        private static string RemoveSettingsSuffix(this string section)
        {
            return section.Replace("Settings", "", StringComparison.Ordinal);
        }

        private static void AddLoggingCustom(this IServiceCollection services)
        {
            services.AddLogging(b =>
            {
                b.AddConsole();
                var appInsightsConfig = b.Services.BuildServiceProvider()
                    .GetService<IOptions<ApplicationInsightsSettings>>();
                b.AddApplicationInsights(appInsightsConfig.Value.InstrumentationKey);
            });
        }

        private static void AddAgentHttpClient(this IServiceCollection services)
        {
            services.AddHttpClient<IAgentHttpClient, AgentHttpClient>().ConfigureHttpMessageHandlerBuilder(b =>
            {
                b.PrimaryHandler = new HttpClientHandler {AllowAutoRedirect = false};
                b.Build();
            });
        }
    }
}