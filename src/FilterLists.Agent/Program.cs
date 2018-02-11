using System;
using System.IO;
using FilterLists.Services.DependencyInjection.Extensions;
using FilterLists.Services.SnapshotService;
using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.Extensibility;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FilterLists.Agent
{
    public class Program
    {
        private static TelemetryClient telemetryClient;
        private static ServiceProvider serviceProvider;
        private static IConfigurationRoot configurationRoot;

        public static int Main(string[] args)
        {
            InstantiateConfigurationRoot();
            InstantiateTelemetryClient();
            InstantiateServiceProvider();

            const int batchSize = 1;
            CaptureSnapshots(batchSize);

            return 0;
        }

        private static void InstantiateConfigurationRoot()
        {
            configurationRoot = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("appsettings.json", false, true)
                                .Build();
        }

        private static void InstantiateTelemetryClient()
        {
            TelemetryConfiguration.Active.InstrumentationKey =
                configurationRoot["ApplicationInsights:InstrumentationKey"];
            telemetryClient = new TelemetryClient();
        }

        private static void InstantiateServiceProvider()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            serviceProvider = serviceCollection.BuildServiceProvider();
        }

        private static void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddFilterListsServices(configurationRoot);
        }

        private static void CaptureSnapshots(int batchSize)
        {
            var snapshotService = serviceProvider.GetService<SnapshotService>();

            Log("Capturing FilterList snapshots...");
            snapshotService.CaptureAsync(batchSize).Wait();
            Log("\nSnapshots captured.");
            telemetryClient.Flush();
        }

        private static void Log(string message)
        {
            Console.WriteLine(message);
            telemetryClient.TrackTrace(message);
        }
    }
}