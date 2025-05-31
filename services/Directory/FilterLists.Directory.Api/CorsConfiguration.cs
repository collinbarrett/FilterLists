using Microsoft.AspNetCore.Cors.Infrastructure;

namespace FilterLists.Directory.Api;

internal static class CorsConfiguration
{
    private const string ProductionClientOrigin = "https://filterlists.com";
    private const string StagingClientOriginStart = "https://nice-water-05873140f";
    private const string StagingClientOriginEnd = ".eastus2.5.azurestaticapps.net";
    private const string LocalClientOrigin = "http://localhost:3000";

    internal static readonly Action<CorsOptions> SetupAction = options => options.AddDefaultPolicy(policy =>
    {
        policy.SetIsOriginAllowed(origin =>
                origin is ProductionClientOrigin or LocalClientOrigin ||
                (origin.StartsWith(StagingClientOriginStart, StringComparison.InvariantCulture) &&
                 origin.EndsWith(StagingClientOriginEnd, StringComparison.InvariantCulture)))
            .WithMethods("GET")
            .AllowAnyHeader();
    });
}