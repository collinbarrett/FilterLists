using System;
using System.Threading;
using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.Extensibility;

namespace FilterLists.Agent
{
    public class Logger : IDisposable
    {
        private readonly TelemetryClient telemetryClient;

        public Logger(string appInsightsKey)
        {
            TelemetryConfiguration.Active.InstrumentationKey = appInsightsKey;
            telemetryClient = new TelemetryClient();
        }

        public void Dispose()
        {
            telemetryClient.Flush();
            Thread.Sleep(5000);
        }

        public void Log(string message)
        {
            Console.WriteLine(message);
            telemetryClient.TrackTrace(message);
        }
    }
}