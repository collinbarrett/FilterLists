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
            logger.Log("Capturing FilterList snapshots...");
            TryCaptureAsync(batchSize).Wait();
            logger.Log("Snapshots captured.");
        }

        private static async Task TryCaptureAsync(int batchSize)
        {
            var snapshotService = serviceProvider.GetService<SnapshotService>();
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