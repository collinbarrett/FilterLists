using System.Threading.Tasks;
using FilterLists.Data.Entities.Junctions;
using FilterLists.Services.Seed;
using FilterLists.Services.Seed.Models.Junctions;
using Microsoft.AspNetCore.Mvc;

namespace FilterLists.Api.V1.Controllers
{
    public class MergesController : BaseController
    {
        public MergesController(SeedService seedService) : base(seedService)
        {
        }

        [HttpGet]
        public async Task<IActionResult> Seed() => Json(await SeedService.GetAllAsync<Merge, MergeSeedDto>(
            typeof(Merge).GetProperty("MergeFilterListId"), typeof(Merge).GetProperty("UpstreamFilterListId")));
    }
}