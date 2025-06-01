namespace FilterLists.Directory.Api;

internal class CachingMiddleware(RequestDelegate next, CachingMiddlewareOptions options)
{
    public async Task InvokeAsync(HttpContext context)
    {
        await next(context);

        if (ShouldApplyCachingHeaders(context))
        {
            context.Response.Headers.CacheControl =
                $"public, s-maxage={options.SharedCacheMaxAgeSeconds}, max-age={options.ClientCacheMaxAgeSeconds}";

            if (options.AddExpiresHeader)
                context.Response.Headers.Expires =
                    DateTime.UtcNow.AddSeconds(options.SharedCacheMaxAgeSeconds).ToString("R");
        }
    }

    private bool ShouldApplyCachingHeaders(HttpContext context)
    {
        return context.Request.Path.StartsWithSegments(options.ApiPathPrefix) &&
               context.Request.Method == HttpMethods.Get &&
               context.Response.StatusCode >= 200 &&
               context.Response.StatusCode < 300 &&
               !context.Response.Headers.ContainsKey("Cache-Control");
    }
}

internal record CachingMiddlewareOptions
{
    public string ApiPathPrefix { get; set; } = "/api";
    public int SharedCacheMaxAgeSeconds { get; set; } = 24 * 60 * 60; // Default 1 day
    public int ClientCacheMaxAgeSeconds { get; set; } = 1 * 60 * 60; // Default 1 hour
    public bool AddExpiresHeader { get; set; }
}

internal static class CachingMiddlewareExtensions
{
    public static IApplicationBuilder UseCustomApiCaching(
        this IApplicationBuilder builder,
        Action<CachingMiddlewareOptions>? configureOptions = null)
    {
        var options = new CachingMiddlewareOptions();
        configureOptions?.Invoke(options);
        return builder.UseMiddleware<CachingMiddleware>(options);
    }
}