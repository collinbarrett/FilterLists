using System;
using FilterLists.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace FilterLists.Api.V1.Controllers
{
    [ApiVersion("1.0")]
    [Route("[controller]")]
    [Produces("application/json")]
    [ResponseCache(CacheProfileName = "Long-Lived")]
    public class ListsController : Controller
    {
        private readonly FilterListService filterListService;
        private readonly IMemoryCache memoryCache;

        public ListsController(IMemoryCache memoryCache, FilterListService filterListService)
        {
            this.memoryCache = memoryCache;
            this.filterListService = filterListService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return memoryCache.GetOrCreate(CacheKeys.Entry, entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(86400);
                return Json(filterListService.GetAllSummaries());
            });
        }
    }
}