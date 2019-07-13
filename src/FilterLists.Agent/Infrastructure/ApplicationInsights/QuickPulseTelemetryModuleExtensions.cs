using Microsoft.ApplicationInsights.Extensibility;
using Microsoft.ApplicationInsights.Extensibility.PerfCounterCollector.QuickPulse;

namespace FilterLists.Agent.Infrastructure.ApplicationInsights
{
    public static class QuickPulseTelemetryModuleExtensions
    {
        public static void InitializeQuickPulseTelemetryModule(this QuickPulseTelemetryModule quickPulseTelemetryModule,
            TelemetryConfiguration telemetryConfiguration)
        {
            QuickPulseTelemetryProcessor processor = null;
            telemetryConfiguration.TelemetryProcessorChainBuilder
                .Use(next =>
                {
                    processor = new QuickPulseTelemetryProcessor(next);
                    return processor;
                })
                .Build();
            quickPulseTelemetryModule.Initialize(telemetryConfiguration);
            quickPulseTelemetryModule.RegisterTelemetryProcessor(processor);
            foreach (var telemetryProcessor in telemetryConfiguration.TelemetryProcessors)
                if (telemetryProcessor is ITelemetryModule telemetryModule)
                    telemetryModule.Initialize(telemetryConfiguration);
        }
    }
}