using System;
using System.Threading.Tasks;
using FilterLists.Data.Entities;
using FilterLists.Services.Models.Seed;
using FilterLists.Services.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace FilterLists.Api.V1.Controllers
{
    public class ListsController : BaseController
    {
        private readonly FilterListService filterListService;
        private readonly SeedService seedService;

        public ListsController(IMemoryCache memoryCache, SeedService seedService, FilterListService filterListService) :
            base(memoryCache)
        {
            this.seedService = seedService;
            this.filterListService = filterListService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return await MemoryCache.GetOrCreateAsync(CacheKeys.Entry, async entry =>
            {
                entry.SlidingExpiration = TimeSpan.FromSeconds(MemoryCacheSlidingExpirationSeconds);
                return Json(await filterListService.GetAllSummaries());
            });
        }

        [HttpGet]
        public async Task<IActionResult> Seed()
        {
            return await MemoryCache.GetOrCreateAsync(CacheKeys.Entry, async entry =>
            {
                entry.SlidingExpiration = TimeSpan.FromSeconds(MemoryCacheSlidingExpirationSeconds);
                return Json(await seedService.GetAll<FilterList, FilterListSeedDto>());
            });
        }
    }
}