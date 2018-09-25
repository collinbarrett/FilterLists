using System.Threading.Tasks;
using FilterLists.Data.Entities.Junctions;
using FilterLists.Services.Seed;
using FilterLists.Services.Seed.Models.Junctions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace FilterLists.Api.V1.Controllers
{
    public class ListsMaintainersController : BaseController
    {
        public ListsMaintainersController(IMemoryCache memoryCache, SeedService seedService)
            : base(memoryCache, seedService)
        {
        }

        [HttpGet("seed")]
        public async Task<IActionResult> Seed() =>
            CoalesceNotFound(Json(await MemoryCache.GetOrCreate("ListsMaintainersController_Seed", entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = MemoryCacheExpirationDefault;
                return SeedService.GetAllAsync<FilterListMaintainer, FilterListMaintainerSeedDto>(
                    typeof(FilterListMaintainer).GetProperty("MaintainerId"),
                    typeof(FilterListMaintainer).GetProperty("FilterListId"));
            })));
    }
}