using Microsoft.ApplicationInsights.Extensibility;
using Microsoft.ApplicationInsights.Extensibility.PerfCounterCollector.QuickPulse;

namespace FilterLists.Agent.Infrastructure.ApplicationInsights
{
    public static class QuickPulseTelemetryModuleBuilder
    {
        public static QuickPulseTelemetryModule Build(TelemetryConfiguration telemetryConfiguration)
        {
            QuickPulseTelemetryProcessor processor = null;
            telemetryConfiguration.TelemetryProcessorChainBuilder
                .Use(next =>
                {
                    processor = new QuickPulseTelemetryProcessor(next);
                    return processor;
                })
                .Build();
            var quickPulseTelemetryModule = new QuickPulseTelemetryModule();
            quickPulseTelemetryModule.Initialize(telemetryConfiguration);
            quickPulseTelemetryModule.RegisterTelemetryProcessor(processor);
            foreach (var telemetryProcessor in telemetryConfiguration.TelemetryProcessors)
                if (telemetryProcessor is ITelemetryModule telemetryModule)
                    telemetryModule.Initialize(telemetryConfiguration);
            return quickPulseTelemetryModule;
        }
    }
}