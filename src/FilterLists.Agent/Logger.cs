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

            //https://docs.microsoft.com/en-us/azure/application-insights/app-insights-api-custom-events-metrics#flushing-data
            Thread.Sleep(5000);
        }

        public void Log(string message)
        {
            Console.WriteLine(message);
            telemetryClient.TrackTrace(message);
        }

        public void Log(Exception e)
        {
            Console.WriteLine(e.Message);
            telemetryClient.TrackException(e);
        }
    }
}