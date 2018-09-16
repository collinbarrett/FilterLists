using System.Threading.Tasks;
using FilterLists.Data.Entities;
using FilterLists.Services.Seed;
using FilterLists.Services.Seed.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace FilterLists.Api.V1.Controllers
{
    public class LicensesController : BaseController
    {
        public LicensesController(IMemoryCache memoryCache, SeedService seedService) : base(memoryCache, seedService)
        {
        }

        [HttpGet("seed")]
        public async Task<IActionResult> Seed() =>
            Json(await MemoryCache.GetOrCreate("LicensesController_Seed", entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = MemoryCacheExpirationDefault;
                return SeedService.GetAllAsync<License, LicenseSeedDto>();
            }));
    }
}