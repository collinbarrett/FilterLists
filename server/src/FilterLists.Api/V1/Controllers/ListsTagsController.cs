using System.Threading.Tasks;
using FilterLists.Api.V1.Interfaces;
using FilterLists.Data.Entities.Junctions;
using FilterLists.Services.Seed;
using FilterLists.Services.Seed.Models.Junctions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace FilterLists.Api.V1.Controllers
{
    public class ListsTagsController : BaseController, ISeed
    {
        public ListsTagsController(IMemoryCache memoryCache, SeedService seedService)
            : base(memoryCache, seedService)
        {
        }

        [HttpGet("seed")]
        public async Task<IActionResult> Seed() =>
            await Get(() => SeedService.GetAllAsync<FilterListTag, FilterListTagSeedDto>(
                typeof(FilterListTag).GetProperty("FilterListId"),
                typeof(FilterListTag).GetProperty("TagId")));
    }
}