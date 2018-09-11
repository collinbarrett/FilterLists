using System;
using FilterLists.Services.Seed;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace FilterLists.Api.V1.Controllers
{
    [ApiVersion("1.0")]
    //TODO: use versioning without needing to manually specify in swagger-ui (https://github.com/domaindrivendev/Swashbuckle.AspNetCore/issues/370)
    [Route("v{version:apiVersion}/[controller]")]
    [ResponseCache(Duration = 86400)]
    public class BaseController : Controller
    {
        protected static readonly TimeSpan MemoryCacheDurationDefault = TimeSpan.FromDays(1);
        protected readonly IMemoryCache MemoryCache;
        protected readonly SeedService SeedService;

        public BaseController()
        {
        }

        protected BaseController(IMemoryCache memoryCache)
        {
            MemoryCache = memoryCache;
        }

        protected BaseController(IMemoryCache memoryCache, SeedService seedService)
        {
            MemoryCache = memoryCache;
            SeedService = seedService;
        }
    }
}