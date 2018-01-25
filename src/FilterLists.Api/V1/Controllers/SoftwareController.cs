using System;
using System.Threading.Tasks;
using FilterLists.Data.Entities;
using FilterLists.Services.Models.Seed;
using FilterLists.Services.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace FilterLists.Api.V1.Controllers
{
    public class SoftwareController : BaseController
    {
        private readonly SeedService seedService;

        public SoftwareController(IMemoryCache memoryCache, SeedService seedService) : base(memoryCache)
        {
            this.seedService = seedService;
        }

        [HttpGet]
        public async Task<IActionResult> Seed()
        {
            return await MemoryCache.GetOrCreateAsync(CacheKeys.Entry, async entry =>
            {
                entry.SlidingExpiration = TimeSpan.FromSeconds(MemoryCacheSlidingExpirationSeconds);
                return Json(await seedService.GetAll<Software, SoftwareSeedDto>());
            });
        }
    }
}