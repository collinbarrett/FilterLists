using System;
using System.IO;
using FilterLists.Services.DependencyInjection.Extensions;
using FilterLists.Services.Snapshot;
using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.Extensibility;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FilterLists.Agent
{
    public static class Program
    {
        private const int BatchSize = 1;
        private const string AiConfigSetting = "ApplicationInsights:InstrumentationKey";
        private static IConfigurationRoot configurationRoot;
        private static ServiceProvider serviceProvider;
        private static TelemetryClient telemetryClient;

        public static void Main()
        {
            BuildConfigurationRoot();
            InstantiateTelemetryClient();
            BuildServiceProvider();
            CaptureSnapshots(BatchSize);
        }

        private static void BuildConfigurationRoot() =>
            configurationRoot = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("appsettings.json", false)
                                .Build();

        private static void InstantiateTelemetryClient()
        {
            TelemetryConfiguration.Active.InstrumentationKey = configurationRoot[AiConfigSetting];
            telemetryClient = new TelemetryClient();
        }

        private static void BuildServiceProvider()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddFilterListsAgentServices(configurationRoot);
            serviceProvider = serviceCollection.BuildServiceProvider();
        }

        private static void CaptureSnapshots(int batchSize)
        {
            var snapshotService = serviceProvider.GetService<SnapshotService>();
            Log("Capturing FilterList snapshots...");
            snapshotService.CaptureAsync(batchSize).Wait();
            Log("Snapshots captured.");
            telemetryClient.Flush();
        }

        private static void Log(string message)
        {
            Console.WriteLine(message);
            telemetryClient.TrackTrace(message);
        }
    }
}