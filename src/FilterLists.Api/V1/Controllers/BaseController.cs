using System;
using FilterLists.Services.Seed;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace FilterLists.Api.V1.Controllers
{
    [ApiVersion("1.0")]
    //TODO: use versioning without needing to manually specify in swagger-ui (https://github.com/domaindrivendev/Swashbuckle.AspNetCore/issues/370)
    [Route("v{version:apiVersion}/[controller]")]
    public class BaseController : Controller
    {
        protected readonly TimeSpan AbsoluteExpirationRelativeToNow = TimeSpan.FromHours(4);
        protected readonly IMemoryCache MemoryCache;
        protected readonly SeedService SeedService;

        public BaseController()
        {
        }

        protected BaseController(SeedService seedService) => SeedService = seedService;

        protected BaseController(IMemoryCache memoryCache, SeedService seedService)
        {
            MemoryCache = memoryCache;
            SeedService = seedService;
        }
    }
}