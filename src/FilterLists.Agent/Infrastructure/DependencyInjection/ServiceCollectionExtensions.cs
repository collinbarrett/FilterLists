using System;
using CommandLine;
using FilterLists.Agent.AppSettings;
using FilterLists.Agent.Infrastructure.Disk;
using FilterLists.Agent.Infrastructure.FilterListsApi;
using FilterLists.Agent.Infrastructure.GitHub;
using FilterLists.Agent.Infrastructure.Polly;
using FilterLists.Agent.Infrastructure.Web;
using MediatR;
using Microsoft.ApplicationInsights;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Serilog;

namespace FilterLists.Agent.Infrastructure.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddConfiguration();
            services.AddLoggingCustom();
            services.AddLocalization();
            services.AddTransient<Parser>();
            services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());
            services.AddPollyPolicyRegistry();
            services.AddDiskServices();
            services.AddFilterListsApiServices();
            services.AddGitHubServices();
            services.AddWebServices();
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
            services.AddSingleton(b =>
            {
                var applicationInsightsSettings = b.GetService<IOptions<ApplicationInsightsSettings>>().Value;
                return new TelemetryClient
                {
                    InstrumentationKey = applicationInsightsSettings.InstrumentationKey
                };
            });
            services.AddLogging(b =>
            {
                var telemetryClient = b.Services.BuildServiceProvider().GetService<TelemetryClient>();
                b.AddSerilog(new LoggerConfiguration()
                    .WriteTo.Console()
                    .WriteTo.ApplicationInsights(telemetryClient, TelemetryConverter.Traces)
                    .CreateLogger());
            });
        }
    }
}