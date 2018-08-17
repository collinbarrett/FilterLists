using System;
using System.IO;
using System.Threading.Tasks;
using FilterLists.Services.DependencyInjection.Extensions;
using FilterLists.Services.Snapshot;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FilterLists.Agent
{
    public static class Program
    {
        private const int BatchSize = 1;
        private const string AppInsightsKeyConfig = "ApplicationInsights:InstrumentationKey";
        private static IConfigurationRoot configRoot;
        private static ServiceProvider serviceProvider;
        private static SnapshotService snapshotService;
        private static Logger logger;

        public static async Task Main()
        {
            BuildConfigRoot();
            BuildServiceProvider();
            snapshotService = serviceProvider.GetService<SnapshotService>();
            using (logger = new Logger(configRoot[AppInsightsKeyConfig]))
            {
                await CaptureSnapshots(BatchSize);
            }
        }

        private static void BuildConfigRoot() =>
            configRoot = new ConfigurationBuilder()
                         .SetBasePath(Directory.GetCurrentDirectory())
                         .AddJsonFile("appsettings.json", false)
                         .Build();

        private static void BuildServiceProvider()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddFilterListsAgentServices(configRoot);
            serviceProvider = serviceCollection.BuildServiceProvider();
        }

        private static async Task CaptureSnapshots(int batchSize)
        {
            logger.Log("Capturing FilterList snapshots...");
            await TryCaptureAsync(batchSize);
            logger.Log("Snapshots captured.");
        }

        private static async Task TryCaptureAsync(int batchSize)
        {
            try
            {
                await snapshotService.CaptureAsync(batchSize);
            }
            catch (Exception e)
            {
                logger.Log(e);
            }
        }
    }
}