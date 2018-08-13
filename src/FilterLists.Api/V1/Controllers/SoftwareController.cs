using System.Threading.Tasks;
using FilterLists.Data.Entities;
using FilterLists.Services.Seed;
using FilterLists.Services.Seed.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace FilterLists.Api.V1.Controllers
{
    public class SoftwareController : BaseController
    {
        public SoftwareController(IMemoryCache memoryCache, SeedService seedService) : base(memoryCache, seedService)
        {
        }

        [HttpGet("seed")]
        public async Task<IActionResult> Seed() =>
            Json(await MemoryCache.GetOrCreate("SoftwareController_Seed", entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = FourHoursFromNow;
                return SeedService.GetAllAsync<Software, SoftwareSeedDto>();
            }));
    }
}