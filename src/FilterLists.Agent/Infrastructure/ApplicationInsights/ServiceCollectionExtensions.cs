using FilterLists.Agent.AppSettings;
using Microsoft.ApplicationInsights.Extensibility;
using Microsoft.ApplicationInsights.Extensibility.PerfCounterCollector.QuickPulse;
using Microsoft.Extensions.DependencyInjection;

namespace FilterLists.Agent.Infrastructure.ApplicationInsights
{
    public static class ServiceCollectionExtensions
    {
        public static void AddApplicationInsights(this IServiceCollection services,
            ApplicationInsightsSettings applicationInsightsSettings)
        {
            services.AddSingleton(b =>
            {
                var telemetryConfiguration = new TelemetryConfiguration(applicationInsightsSettings.InstrumentationKey);
                return new QuickPulseTelemetryModuleBuilder(telemetryConfiguration).Build();
            });

            // init never resolved singleton
            services.BuildServiceProvider().GetService<QuickPulseTelemetryModule>();
        }
    }
}