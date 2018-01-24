using System;
using FilterLists.Services.Models;
using FilterLists.Services.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace FilterLists.Api.V1.Controllers
{
    [ApiVersion("1.0")]
    [Produces("application/json")]
    [ResponseCache(CacheProfileName = "Long-Lived")]
    public class BaseController : Controller
    {
        protected readonly IMemoryCache MemoryCache;
        protected readonly SeedService SeedService;

        public BaseController(IMemoryCache memoryCache, SeedService seedService)
        {
            MemoryCache = memoryCache;
            SeedService = seedService;
        }

        [HttpGet]
        public IActionResult Seed()
        {
            var controllerName = ControllerContext.RouteData.Values["controller"].ToString();
            return MemoryCache.GetOrCreate(CacheKeys.Entry, entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(86400);
                //TODO: GetAll<T>() by seed type of request controller
                return Json(SeedService.GetAll<FilterListSeedDto>());
            });
        }
    }
}