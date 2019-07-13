using System;
using System.Threading;
using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.Extensibility;

namespace FilterLists.Agent.Infrastructure.ApplicationInsights
{
    public class AgentTelemetryClient : IDisposable
    {
        public AgentTelemetryClient(TelemetryConfiguration telemetryConfiguration)
        {
            TelemetryClient = new TelemetryClient(telemetryConfiguration);
        }

        public TelemetryClient TelemetryClient { get; }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposing)
                return;
            TelemetryClient.Flush();
            Thread.Sleep(5000);
        }
    }
}