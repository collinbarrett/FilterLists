using Hangfire;
using Hangfire.Storage;

namespace FilterLists.Archival.Infrastructure.Scheduling;

public static class HangfireExtensions
{
    // https://github.com/HangfireIO/Hangfire/issues/394#issuecomment-179924221
    public static void PurgeJobs(this IMonitoringApi monitoringApi)
    {
        var toDelete = new List<string>();
        foreach (var queue in monitoringApi.Queues())
        {
            for (var i = 0; i < Math.Ceiling(queue.Length / 1000d); i++)
            {
                toDelete.AddRange(monitoringApi.EnqueuedJobs(queue.Name, 1000 * i, 1000).Select(x => x.Key));
            }
        }

        foreach (var jobId in toDelete)
        {
            BackgroundJob.Delete(jobId);
        }
    }
}
