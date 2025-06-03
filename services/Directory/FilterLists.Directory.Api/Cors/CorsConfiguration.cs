namespace FilterLists.Directory.Api.Cors;

internal static class CorsConfiguration
{
    internal static readonly Action<Microsoft.AspNetCore.Cors.Infrastructure.CorsOptions, IConfiguration> SetupAction =
        (options, configuration) =>
        {
            var corsOptions = configuration.GetSection(CorsOptions.Cors).Get<CorsOptions>() ??
                              throw new InvalidOperationException("CORS options are not configured.");

            options.AddDefaultPolicy(policy => policy
                .SetIsOriginAllowed(origin =>
                {
                    if (corsOptions.AllowedOrigins.Any(o => string.Equals(o, origin, StringComparison.OrdinalIgnoreCase)))
                        return true;

                    if (corsOptions.StagingOriginPatterns is { } patterns &&
                        !string.IsNullOrEmpty(patterns.Start) &&
                        !string.IsNullOrEmpty(patterns.End) &&
                        origin.StartsWith(patterns.Start, StringComparison.OrdinalIgnoreCase) &&
                        origin.EndsWith(patterns.End, StringComparison.OrdinalIgnoreCase))
                        return true;

                    return false;
                })
                .WithMethods("GET")
                .AllowAnyHeader());
        };
}