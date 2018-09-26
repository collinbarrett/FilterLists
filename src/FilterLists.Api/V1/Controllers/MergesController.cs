using System.Threading.Tasks;
using FilterLists.Api.V1.Interfaces;
using FilterLists.Data.Entities.Junctions;
using FilterLists.Services.Seed;
using FilterLists.Services.Seed.Models.Junctions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace FilterLists.Api.V1.Controllers
{
    public class MergesController : BaseController, ISeed
    {
        public MergesController(IMemoryCache memoryCache, SeedService seedService) : base(memoryCache, seedService)
        {
        }

        [HttpGet("seed")]
        public async Task<IActionResult> Seed() =>
            await Get(() => SeedService.GetAllAsync<Merge, MergeSeedDto>(
                typeof(Merge).GetProperty("MergeFilterListId"),
                typeof(Merge).GetProperty("UpstreamFilterListId")));
    }
}