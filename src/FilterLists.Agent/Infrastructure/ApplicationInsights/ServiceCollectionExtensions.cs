using FilterLists.Agent.AppSettings;
using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.Extensibility;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace FilterLists.Agent.Infrastructure.ApplicationInsights
{
    public static class ServiceCollectionExtensions
    {
        public static void AddApplicationInsights(this IServiceCollection services)
        {
            services.AddSingleton(b =>
            {
                var applicationInsightsSettings = b.GetService<IOptions<ApplicationInsightsSettings>>().Value;
                return new TelemetryConfiguration
                {
                    InstrumentationKey = applicationInsightsSettings.InstrumentationKey
                };
            });
            services.AddSingleton(b =>
            {
                var configuration = b.GetService<TelemetryConfiguration>();
                return new TelemetryClient(configuration);
            });
        }
    }
}