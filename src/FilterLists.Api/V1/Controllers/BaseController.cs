using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using FilterLists.Services.Seed;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace FilterLists.Api.V1.Controllers
{
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/[controller]")]
    [ResponseCache(Duration = 30)]
    public abstract class BaseController : Controller
    {
        private static readonly TimeSpan MemoryCacheExpirationDefault = TimeSpan.FromSeconds(30);
        protected readonly SeedService SeedService;
        private readonly IMemoryCache memoryCache;

        protected BaseController()
        {
        }

        protected BaseController(IMemoryCache memoryCache) => this.memoryCache = memoryCache;

        protected BaseController(IMemoryCache memoryCache, SeedService seedService)
        {
            this.memoryCache = memoryCache;
            SeedService = seedService;
        }

        //https://stackoverflow.com/a/52506210/2343739
        protected async Task<IActionResult> Get<T>(Func<Task<T>> createAction, int? paramCacheKey = null,
            [CallerMemberName] string actionName = null)
        {
            var cacheKey = GetType().Name + "_" + actionName + "_" + paramCacheKey;
            var result = await memoryCache.GetOrCreateAsync(cacheKey, entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = MemoryCacheExpirationDefault;
                return createAction();
            });
            return CoalesceNotFound(Json(result));
        }

        private IActionResult CoalesceNotFound(JsonResult result) =>
            result.Value is null ? NotFound() : (IActionResult)result;
    }
}