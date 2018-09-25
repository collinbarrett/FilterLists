using System.Threading.Tasks;
using FilterLists.Data.Entities.Junctions;
using FilterLists.Services.Seed;
using FilterLists.Services.Seed.Models.Junctions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace FilterLists.Api.V1.Controllers
{
    public class DependentsController : BaseController
    {
        public DependentsController(IMemoryCache memoryCache, SeedService seedService) : base(memoryCache, seedService)
        {
        }

        [HttpGet("seed")]
        public async Task<IActionResult> Seed() =>
            CoalesceNotFound(Json(await MemoryCache.GetOrCreate("DependentsController_Seed", entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = MemoryCacheExpirationDefault;
                return SeedService.GetAllAsync<Dependent, DependentSeedDto>(typeof(Dependent).GetProperty("DependentFilterListId"),
                    typeof(Dependent).GetProperty("DependencyFilterListId"));
            })));
    }
}