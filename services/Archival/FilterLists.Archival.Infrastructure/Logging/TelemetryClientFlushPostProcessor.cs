using System.Threading;
using System.Threading.Tasks;
using MediatR.Pipeline;
using Microsoft.ApplicationInsights;

namespace FilterLists.Archival.Infrastructure.Logging
{
    /// <remarks>https://docs.microsoft.com/en-us/azure/azure-monitor/app/api-custom-events-metrics#flushing-data</remarks>
    public class TelemetryClientFlushPostProcessor<TRequest, TResponse> : IRequestPostProcessor<TRequest, TResponse>
        where TRequest : notnull
    {
        private readonly TelemetryClient _telemetryClient;

        public TelemetryClientFlushPostProcessor(TelemetryClient telemetryClient)
        {
            _telemetryClient = telemetryClient;
        }

        public Task Process(TRequest request, TResponse response, CancellationToken cancellationToken)
        {
            _telemetryClient.Flush();

            // Allow some time for flushing before shutdown.
            Thread.Sleep(5000);

            return Task.CompletedTask;
        }
    }
}
