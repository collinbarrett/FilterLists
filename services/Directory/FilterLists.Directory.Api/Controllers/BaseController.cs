using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace FilterLists.Directory.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public abstract class BaseController : ControllerBase
    {
        private readonly IMemoryCache _cache;

        protected BaseController(IMemoryCache cache)
        {
            _cache = cache;
        }

        /// <remarks>https://stackoverflow.com/a/52506210/2343739</remarks>
        protected async Task<IActionResult> CacheGetOrCreateAsync<TResponse>(
            Func<Task<TResponse>> actionAsync,
            int? keySuffix = default,
            TimeSpan? absoluteExpirationRelativeToNow = default,
            [CallerMemberName] string key = default!)
        {
            var cacheKey = $"{GetType().Name}_{key}{(keySuffix is null ? string.Empty : $"_{keySuffix}")}";
            var result = await _cache.GetOrCreateAsync(cacheKey, entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = absoluteExpirationRelativeToNow;
                return actionAsync();
            });
            return result is null ? NotFound() : Ok(result);
        }
    }
}
