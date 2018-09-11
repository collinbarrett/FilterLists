using System.Threading.Tasks;
using FilterLists.Data.Entities.Junctions;
using FilterLists.Services.Seed;
using FilterLists.Services.Seed.Models.Junctions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace FilterLists.Api.V1.Controllers
{
    public class ListsTagsController : BaseController
    {
        public ListsTagsController(IMemoryCache memoryCache, SeedService seedService)
            : base(memoryCache, seedService)
        {
        }

        [HttpGet("seed")]
        public async Task<IActionResult> Seed() =>
            Json(await MemoryCache.GetOrCreate("ListsTagsController_Seed", entry =>
            {
                entry.SlidingExpiration = MemoryCacheSlidingExpirationDefault;
                return SeedService.GetAllAsync<FilterListTag, FilterListTagSeedDto>(
                    typeof(FilterListTag).GetProperty("FilterListId"),
                    typeof(FilterListTag).GetProperty("TagId"));
            }));
    }
}