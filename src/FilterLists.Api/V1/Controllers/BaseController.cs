using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace FilterLists.Api.V1.Controllers
{
    [ApiVersion("1.0")]
    [Produces("application/json")]
    [ResponseCache(CacheProfileName = "Long-Lived")]
    public class BaseController : Controller
    {
        protected const int MemoryCacheSlidingExpirationSeconds = 30;
        protected readonly IMemoryCache MemoryCache;

        protected BaseController(IMemoryCache memoryCache)
        {
            MemoryCache = memoryCache;
        }
    }
}