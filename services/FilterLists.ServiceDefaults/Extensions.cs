using Azure.Monitor.OpenTelemetry.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.ServiceDiscovery;
using OpenTelemetry;
using OpenTelemetry.Metrics;
using OpenTelemetry.Trace;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.Hosting;

public static class Extensions
{
    private const string HealthEndpointPath = "/health";
    private const string AlivenessEndpointPath = "/alive";
    private const string HealthCheckPolicyName = "HealthChecks";

    public static void AddServiceDefaults<TBuilder>(this TBuilder builder) where TBuilder : IHostApplicationBuilder
    {
        builder.ConfigureOpenTelemetry();
        builder.AddDefaultHealthChecks();
        builder.Services.AddServiceDiscovery();
        builder.Services.ConfigureHttpClientDefaults(http =>
        {
            http.AddStandardResilienceHandler();
            http.AddServiceDiscovery();
        });

        builder.Services.Configure<ServiceDiscoveryOptions>(options => options.AllowedSchemes = ["https"]);
    }

    private static void ConfigureOpenTelemetry<TBuilder>(this TBuilder builder) where TBuilder : IHostApplicationBuilder
    {
        builder.Logging.AddOpenTelemetry(logging =>
        {
            logging.IncludeFormattedMessage = true;
            logging.IncludeScopes = true;
        });

        var otBuilder = builder.Services.AddOpenTelemetry()
            .WithMetrics(metrics =>
                metrics.AddAspNetCoreInstrumentation()
                    .AddHttpClientInstrumentation()
                    .AddRuntimeInstrumentation())
            .WithTracing(tracing =>
                tracing.AddSource(builder.Environment.ApplicationName)
                    .AddAspNetCoreInstrumentation(tracingOptions =>
                        tracingOptions.Filter = context =>
                            !context.Request.Path.StartsWithSegments(HealthEndpointPath,
                                StringComparison.InvariantCultureIgnoreCase)
                            && !context.Request.Path.StartsWithSegments(AlivenessEndpointPath,
                                StringComparison.InvariantCultureIgnoreCase)
                    )
                    .AddHttpClientInstrumentation());

        if (!string.IsNullOrWhiteSpace(builder.Configuration["OTEL_EXPORTER_OTLP_ENDPOINT"]))
            otBuilder.UseOtlpExporter();

        if (!string.IsNullOrEmpty(builder.Configuration["APPLICATIONINSIGHTS_CONNECTION_STRING"]))
            otBuilder.UseAzureMonitor();
    }

    // https://learn.microsoft.com/en-us/dotnet/aspire/fundamentals/health-checks#non-development-environments
    private static void AddDefaultHealthChecks(this IHostApplicationBuilder builder)
    {
        builder.Services.AddRequestTimeouts();
        builder.Services.AddOutputCache();

        builder.Services.AddRequestTimeouts(static timeouts =>
            timeouts.AddPolicy(HealthCheckPolicyName, TimeSpan.FromSeconds(5)));

        builder.Services.AddOutputCache(static caching =>
            caching.AddPolicy(HealthCheckPolicyName, static policy => policy.Expire(TimeSpan.FromSeconds(10))));

        builder.Services.AddHealthChecks()
            .AddCheck("self", () => HealthCheckResult.Healthy(), ["live"]);
    }

    // https://learn.microsoft.com/en-us/dotnet/aspire/fundamentals/health-checks#non-development-environments
    public static void MapDefaultEndpoints(this WebApplication app)
    {
        app.UseRequestTimeouts();
        app.UseOutputCache();

        var healthChecks = app.MapGroup("");

        healthChecks
            .CacheOutput(HealthCheckPolicyName)
            .WithRequestTimeout(HealthCheckPolicyName);

        healthChecks.MapHealthChecks(HealthEndpointPath).DisableHttpMetrics();
        healthChecks.MapHealthChecks(AlivenessEndpointPath, new HealthCheckOptions
            {
                Predicate = static r => r.Tags.Contains("live")
            })
            .DisableHttpMetrics();
    }
}