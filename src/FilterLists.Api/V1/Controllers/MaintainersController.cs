using System.Threading.Tasks;
using FilterLists.Data.Entities;
using FilterLists.Services.Seed;
using FilterLists.Services.Seed.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace FilterLists.Api.V1.Controllers
{
    public class MaintainersController : BaseController
    {
        public MaintainersController(IMemoryCache memoryCache, SeedService seedService) : base(memoryCache, seedService)
        {
        }

        [HttpGet("seed")]
        public async Task<IActionResult> Seed() =>
            Json(await MemoryCache.GetOrCreate("MaintainersController_Seed", entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = MemoryCacheDurationDefault;
                return SeedService.GetAllAsync<Maintainer, MaintainerSeedDto>();
            }));
    }
}