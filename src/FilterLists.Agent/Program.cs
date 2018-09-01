using System;
using System.IO;
using System.Threading.Tasks;
using FilterLists.Services;
using FilterLists.Services.DependencyInjection.Extensions;
using FilterLists.Services.Extensions;
using FilterLists.Services.Snapshot;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FilterLists.Agent
{
    public static class Program
    {
        private const int BatchSize = 1;
        private static IConfigurationRoot configRoot;
        private static ServiceProvider serviceProvider;
        private static SnapshotService snapshotService;
        private static Logger logger;
        private static readonly TimeSpan Timeout = TimeSpan.FromHours(48);

        public static async Task Main()
        {
            BuildConfigRoot();
            BuildServiceProvider();
            snapshotService = serviceProvider.GetService<SnapshotService>();
            logger = serviceProvider.GetService<Logger>();
            await TryCaptureSnapshots();
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

        private static async Task TryCaptureSnapshots()
        {
            try
            {
                await CaptureSnapshots(BatchSize).TimeoutAfter(Timeout);
            }
            catch (TimeoutException te)
            {
                logger.Log(te);
            }
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