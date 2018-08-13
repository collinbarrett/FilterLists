using System.Threading.Tasks;
using FilterLists.Data.Entities;
using FilterLists.Services.Seed;
using FilterLists.Services.Seed.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace FilterLists.Api.V1.Controllers
{
    public class LanguagesController : BaseController
    {
        public LanguagesController(IMemoryCache memoryCache, SeedService seedService) : base(memoryCache, seedService)
        {
        }

        [HttpGet("seed")]
        public async Task<IActionResult> Seed() =>
            Json(await MemoryCache.GetOrCreate("LanguagesController_Seed", entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = FourHoursFromNow;
                return SeedService.GetAllAsync<Language, LanguageSeedDto>();
            }));
    }
}