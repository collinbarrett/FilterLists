using System.Threading.Tasks;
using FilterLists.Data.Entities.Junctions;
using FilterLists.Services.Seed;
using FilterLists.Services.Seed.Models.Junctions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace FilterLists.Api.V1.Controllers
{
    public class SoftwareSyntaxesController : BaseController
    {
        public SoftwareSyntaxesController(IMemoryCache memoryCache, SeedService seedService)
            : base(memoryCache, seedService)
        {
        }

        [HttpGet("seed")]
        public async Task<IActionResult> Seed() =>
            CoalesceNotFound(Json(await MemoryCache.GetOrCreate("SoftwareSyntaxesController_Seed", entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = MemoryCacheExpirationDefault;
                return SeedService.GetAllAsync<SoftwareSyntax, SoftwareSyntaxSeedDto>(
                    typeof(SoftwareSyntax).GetProperty("SyntaxId"), typeof(SoftwareSyntax).GetProperty("SoftwareId"));
            })));
    }
}