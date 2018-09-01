using System;
using System.Threading;
using JetBrains.Annotations;
using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.Extensibility;
using Microsoft.Extensions.Configuration;

namespace FilterLists.Services
{
    [UsedImplicitly]
    public class Logger : IDisposable
    {
        private const string AppInsightsKeyConfig = "ApplicationInsights:InstrumentationKey";
        private readonly TelemetryClient telemetryClient;

        public Logger(IConfiguration config)
        {
            TelemetryConfiguration.Active.InstrumentationKey = config[AppInsightsKeyConfig];
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