using System;
using System.Net;
using System.Net.Http;
using CommandLine;
using FilterLists.Agent.AppSettings;
using FilterLists.Agent.Core;
using FilterLists.Agent.Core.List;
using FilterLists.Agent.Infrastructure.FilterListsApi;
using FilterLists.Agent.Infrastructure.GitHub;
using LibGit2Sharp;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Polly;
using Serilog;

namespace FilterLists.Agent.Infrastructure.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterAgentServices(this IServiceCollection services)
        {
            services.AddConfiguration();
            services.AddLoggingCustom();
            services.AddLocalization();
            services.AddTransient<Parser>();
            services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());
            services.AddFilterListsApiResources();
            services.AddGitHubResources();
            services.AddUrlRepository();
            services.AddListRepository();
            services.AddArchiveRepository();
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
            services.ConfigureCustom<ArchiveSettings>(config);
            services.ConfigureCustom<ConnectionStringSettings>(config);
            services.ConfigureCustom<FilterListsApiSettings>(config);
            services.ConfigureCustom<GitHubSettings>(config);
        }

        private static void ConfigureCustom<TSettings>(this IServiceCollection services, IConfiguration configuration)
            where TSettings : class
        {
            services.Configure<TSettings>(
                configuration.GetSection(typeof(TSettings).Name.Replace("Settings", "", StringComparison.Ordinal)));
        }

        private static void AddLoggingCustom(this IServiceCollection services)
        {
            services.AddLogging(b =>
            {
                b.AddSerilog(new LoggerConfiguration().WriteTo.Console().CreateLogger());
                var applicationInsightsSettings = b.Services.BuildServiceProvider()
                    .GetService<IOptions<ApplicationInsightsSettings>>().Value;
                b.AddApplicationInsights(applicationInsightsSettings.InstrumentationKey);
            });
        }

        private static void AddUrlRepository(this IServiceCollection services)
        {
            services.AddHttpClient<IUrlRepository, UrlRepository>()
                .ConfigureHttpMessageHandlerBuilder(b =>
                {
                    b.PrimaryHandler = new HttpClientHandler {AllowAutoRedirect = false};
                    b.Build();
                })
                .AddTransientHttpErrorPolicy(b =>
                    b.OrResult(r => r.StatusCode == HttpStatusCode.TooManyRequests)
                        .WaitAndRetryAsync(5, i => i * TimeSpan.FromSeconds(3)));
        }

        private static void AddListRepository(this IServiceCollection services)
        {
            services.AddHttpClient<IListRepository, ListRepository>().AddTransientHttpErrorPolicy(b =>
                b.OrResult(r => r.StatusCode == HttpStatusCode.TooManyRequests)
                    .WaitAndRetryAsync(5, i => i * TimeSpan.FromSeconds(3)));
        }

        private static void AddArchiveRepository(this IServiceCollection services)
        {
            services.AddTransient<IRepository, Repository>(s =>
            {
                var archiveSettings = s.GetService<IOptions<ArchiveSettings>>().Value;
                if (!Repository.IsValid(archiveSettings.RepositoryDirectory))
                    Repository.Init(archiveSettings.RepositoryDirectory);
                return new Repository(archiveSettings.RepositoryDirectory);
            });
        }
    }
}