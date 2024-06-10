using System.Runtime.CompilerServices;
using Microsoft.Extensions.Caching.Memory;

namespace FilterLists.Directory.Infrastructure;

public static class MemoryCacheExtension
{
    public static async IAsyncEnumerable<TResponse> GetOrCreateAsyncEnumerable<TResponse>(
        this IMemoryCache cache,
        object key,
        ConfiguredCancelableAsyncEnumerable<TResponse> query,
        MemoryCacheEntryOptions? options = null) where TResponse : class
    {
        if (cache.TryGetValue(key, out List<TResponse>? cachedElements))
        {
            foreach (var element in cachedElements ?? []) yield return element;
        }
        else
        {
            var elementsToCache = new List<TResponse>();
            await foreach (var element in query)
            {
                elementsToCache.Add(element);
                yield return element;
            }

            cache.Set(key, elementsToCache, options);
        }
    }
}