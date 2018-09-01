using System;
using System.Threading;
using System.Threading.Tasks;

namespace FilterLists.Services.Extensions
{
    public static class TaskExtensions
    {
        //https://stackoverflow.com/a/22078975/2343739
        public static async Task TimeoutAfter(this Task task, TimeSpan timeout)
        {
            using (var cancellationTokenSource = new CancellationTokenSource())
            {
                var completedTask = await Task.WhenAny(task, Task.Delay(timeout, cancellationTokenSource.Token));
                if (completedTask != task)
                    throw new TimeoutException("The operation has timed out.");
                cancellationTokenSource.Cancel();
                await task;
            }
        }
    }
}