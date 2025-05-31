using Microsoft.AspNetCore.Cors.Infrastructure;

namespace FilterLists.Directory.Api;

internal static class CorsConfiguration
{
    internal static readonly Action<CorsOptions> SetupAction = options =>
        options.AddDefaultPolicy(policy =>
            policy
                .AllowAnyOrigin()
                .WithMethods("GET")
                .AllowAnyHeader()
        );
}