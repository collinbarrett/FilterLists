using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using FilterLists.Services.Seed;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace FilterLists.Api.V1.Controllers
{
    [ApiVersion("1.0")]
    //TODO: use versioning without needing to manually specify in swagger-ui (https://github.com/domaindrivendev/Swashbuckle.AspNetCore/issues/370)
    [Route("v{version:apiVersion}/[controller]")]
    [ResponseCache(Duration = 14400)]
    public class BaseController : Controller
    {
        private static readonly TimeSpan MemoryCacheExpirationDefault = TimeSpan.FromHours(4);
        protected readonly SeedService SeedService;
        private readonly IMemoryCache memoryCache;

        public BaseController()
        {
        }

        protected BaseController(IMemoryCache memoryCache) => this.memoryCache = memoryCache;

        protected BaseController(IMemoryCache memoryCache, SeedService seedService)
        {
            this.memoryCache = memoryCache;
            SeedService = seedService;
        }

        protected async Task<IActionResult> Get<T>(Func<Task<T>> createAction, int? actionParam = null,
            [CallerMemberName] string actionName = null)
        {
            var cacheKey = GetType().Name + "_" + actionName + "_" + actionParam;
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