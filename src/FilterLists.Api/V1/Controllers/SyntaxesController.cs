using System.Threading.Tasks;
using FilterLists.Data.Entities;
using FilterLists.Services.Seed;
using FilterLists.Services.Seed.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace FilterLists.Api.V1.Controllers
{
    public class SyntaxesController : BaseController
    {
        public SyntaxesController(IMemoryCache memoryCache, SeedService seedService) : base(memoryCache, seedService)
        {
        }

        [HttpGet("seed")]
        public async Task<IActionResult> Seed() =>
            Json(await MemoryCache.GetOrCreate("SyntaxesController_Seed", entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = MemoryCacheExpirationDefault;
                return SeedService.GetAllAsync<Syntax, SyntaxSeedDto>();
            }));
    }
}