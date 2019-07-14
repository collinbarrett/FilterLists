using Microsoft.ApplicationInsights.Extensibility;
using Microsoft.ApplicationInsights.Extensibility.PerfCounterCollector.QuickPulse;

namespace FilterLists.Agent.Infrastructure.ApplicationInsights
{
    public class QuickPulseTelemetryModuleBuilder
    {
        private readonly TelemetryConfiguration _telemetryConfiguration;

        public QuickPulseTelemetryModuleBuilder(TelemetryConfiguration telemetryConfiguration)
        {
            _telemetryConfiguration = telemetryConfiguration;
        }

        public QuickPulseTelemetryModule Build()
        {
            QuickPulseTelemetryProcessor processor = null;
            _telemetryConfiguration.TelemetryProcessorChainBuilder
                .Use(next =>
                {
                    processor = new QuickPulseTelemetryProcessor(next);
                    return processor;
                })
                .Build();
            var quickPulseTelemetryModule = new QuickPulseTelemetryModule();
            quickPulseTelemetryModule.Initialize(_telemetryConfiguration);
            quickPulseTelemetryModule.RegisterTelemetryProcessor(processor);
            foreach (var telemetryProcessor in _telemetryConfiguration.TelemetryProcessors)
                if (telemetryProcessor is ITelemetryModule telemetryModule)
                    telemetryModule.Initialize(_telemetryConfiguration);
            return quickPulseTelemetryModule;
        }
    }
}