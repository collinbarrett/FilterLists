using System;
using System.IO;
using FilterLists.Services.DependencyInjection.Extensions;
using FilterLists.Services.Snapshot;
using JetBrains.Annotations;
using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.Extensibility;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FilterLists.Agent
{
    [UsedImplicitly]
    public class Program
    {
        private const int BatchSize = 1;
        private static TelemetryClient _telemetryClient;
        private static ServiceProvider _serviceProvider;
        private static IConfigurationRoot _configurationRoot;

        public static int Main()
        {
            InstantiateConfigurationRoot();
            InstantiateTelemetryClient();
            InstantiateServiceProvider();
            CaptureSnapshots(BatchSize);
            return 0;
        }

        private static void InstantiateConfigurationRoot()
        {
            _configurationRoot = new ConfigurationBuilder()
                                 .SetBasePath(Directory.GetCurrentDirectory())
                                 .AddJsonFile("appsettings.json", false, true)
                                 .Build();
        }

        private static void InstantiateTelemetryClient()
        {
            TelemetryConfiguration.Active.InstrumentationKey =
                _configurationRoot["ApplicationInsights:InstrumentationKey"];
            _telemetryClient = new TelemetryClient();
        }

        private static void InstantiateServiceProvider()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            _serviceProvider = serviceCollection.BuildServiceProvider();
        }

        private static void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddFilterListsServices(_configurationRoot);
        }

        private static void CaptureSnapshots(int batchSize)
        {
            var snapshotService = _serviceProvider.GetService<SnapshotService>();
            Log("Capturing FilterList snapshots...");
            snapshotService.CaptureAsync(batchSize).Wait();
            Log("\nSnapshots captured.");
            _telemetryClient.Flush();
        }

        private static void Log(string message)
        {
            Console.WriteLine(message);
            _telemetryClient.TrackTrace(message);
        }
    }
}