using System.Threading.Tasks;
using FilterLists.Data.Entities.Junctions;
using FilterLists.Services.SeedService;
using FilterLists.Services.SeedService.Models.Junctions;
using Microsoft.AspNetCore.Mvc;

namespace FilterLists.Api.V1.Controllers
{
    public class MergesController : BaseController
    {
        private readonly SeedService seedService;

        public MergesController(SeedService seedService)
        {
            this.seedService = seedService;
        }

        [HttpGet]
        public async Task<IActionResult> Seed()
        {
            return Json(await seedService.GetAllAsync<Merge, MergeSeedDto>(
                typeof(Merge).GetProperty("MergeFilterListId"),
                typeof(Merge).GetProperty("UpstreamFilterListId")));
        }
    }
}