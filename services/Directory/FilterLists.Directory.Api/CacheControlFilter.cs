using Microsoft.Net.Http.Headers;

namespace FilterLists.Directory.Api;

internal sealed class CacheControlFilter(int clientCacheSeconds, int cdnCacheSeconds) : IEndpointFilter
{
    private readonly string _cacheControlHeaderValue = new CacheControlHeaderValue
        {
            Public = true,
            MaxAge = TimeSpan.FromSeconds(clientCacheSeconds),
            SharedMaxAge = TimeSpan.FromSeconds(cdnCacheSeconds)
        }
        .ToString();

    public async ValueTask<object?> InvokeAsync(
        EndpointFilterInvocationContext context,
        EndpointFilterDelegate next)
    {
        var result = await next(context);

        if (context.HttpContext.Response.StatusCode is >= 200 and < 300)
            context.HttpContext.Response.Headers.CacheControl = _cacheControlHeaderValue;

        return result;
    }
}