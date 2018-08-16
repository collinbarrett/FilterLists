using System.IO;
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
        private static Logger logger;

        public static void Main()
        {
            BuildConfigRoot();
            BuildServiceProvider();
            using (BuildLogger())
            {
                CaptureSnapshots(BatchSize);
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

        private static Logger BuildLogger() => logger = new Logger(configRoot[AppInsightsKeyConfig]);

        private static void CaptureSnapshots(int batchSize)
        {
            var snapshotService = serviceProvider.GetService<SnapshotService>();
            logger.Log("Capturing FilterList snapshots...");
            snapshotService.CaptureAsync(batchSize).Wait();
            logger.Log("Snapshots captured.");
        }
    }
}