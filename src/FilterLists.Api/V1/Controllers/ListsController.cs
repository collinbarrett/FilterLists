using System;
using System.Threading.Tasks;
using FilterLists.Services.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace FilterLists.Api.V1.Controllers
{
    public class ListsController : EntityController
    {
        private readonly FilterListService filterListService;

        public ListsController(IMemoryCache memoryCache, SeedService seedService, FilterListService filterListService) :
            base(memoryCache, seedService)
        {
            this.filterListService = filterListService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return await MemoryCache.GetOrCreateAsync(CacheKeys.Entry, async entry =>
            {
                entry.SlidingExpiration = TimeSpan.FromSeconds(3);
                return Json(await filterListService.GetAllSummaries());
            });
        }
    }
}