using System;
using CommandLine;
using FilterLists.Agent.AppSettings;
using FilterLists.Agent.Extensions;
using FilterLists.Agent.Infrastructure.ApplicationInsights;
using FilterLists.Agent.Infrastructure.Disk;
using FilterLists.Agent.Infrastructure.FilterListsApi;
using FilterLists.Agent.Infrastructure.GitHub;
using FilterLists.Agent.Infrastructure.Polly;
using FilterLists.Agent.Infrastructure.Web;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog;

namespace FilterLists.Agent.Infrastructure.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        private static IConfigurationRoot Configuration { get; } = new ConfigurationBuilder()
            .AddEnvironmentVariables()
            .AddJsonFile("appsettings.json", true, true)
#if DEBUG
            .AddJsonFile("appsettings.Development.json", true, true)
#endif
            .Build();

        private static ApplicationInsightsSettings ApplicationInsightsSettings { get; } =
            Configuration.GetSettings<ApplicationInsightsSettings>();

        public static void ConfigureServices(this IServiceCollection services)
        {
            services.ConfigureSettings();
            services.AddLogging();
            services.AddApplicationInsights(ApplicationInsightsSettings);
            services.AddLocalization();
            services.AddTransient<Parser>();
            services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());
            services.AddPollyPolicyRegistry();
            services.AddDiskServices(Configuration.GetSettings<ArchiveSettings>());
            services.AddFilterListsApiServices();
            services.AddGitHubServices(Configuration.GetSettings<GitHubSettings>());
            services.AddWebServices();
        }

        private static void ConfigureSettings(this IServiceCollection services)
        {
            services.Configure<ApplicationInsightsSettings>();
            services.Configure<ArchiveSettings>();
            services.Configure<ConnectionStringSettings>();
            services.Configure<FilterListsApiSettings>();
            services.Configure<GitHubSettings>();
        }

        private static void Configure<TSettings>(this IServiceCollection services) where TSettings : class
        {
            services.Configure<TSettings>(Configuration.GetSection<TSettings>());
        }

        private static void AddLogging(this IServiceCollection services)
        {
            services.AddLogging(b =>
            {
                var instrumentationKey = ApplicationInsightsSettings.InstrumentationKey;
                var telemetryClient = new AgentTelemetryClient(instrumentationKey).TelemetryClient;
                var logger = new LoggerConfiguration()
                    .WriteTo.Console()
                    .WriteTo.ApplicationInsights(telemetryClient, TelemetryConverter.Traces)
                    .CreateLogger();
                b.AddSerilog(logger);
            });
        }
    }
}