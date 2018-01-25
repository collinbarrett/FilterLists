using System;
using System.Threading.Tasks;
using FilterLists.Data.Entities.Junctions;
using FilterLists.Services.Models.Seed.Junctions;
using FilterLists.Services.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace FilterLists.Api.V1.Controllers
{
    public class ForksController : BaseController
    {
        private readonly SeedService seedService;

        public ForksController(IMemoryCache memoryCache, SeedService seedService) : base(memoryCache)
        {
            this.seedService = seedService;
        }

        [HttpGet]
        public async Task<IActionResult> Seed()
        {
            return await MemoryCache.GetOrCreateAsync(CacheKeys.Entry, async entry =>
            {
                entry.SlidingExpiration = TimeSpan.FromSeconds(MemoryCacheSlidingExpirationSeconds);
                return Json(await seedService.GetAll<Fork, ForkSeedDto>());
            });
        }
    }
}