using System.Threading.Tasks;
using FilterLists.Data.Entities.Junctions;
using FilterLists.Services.Seed;
using FilterLists.Services.Seed.Models.Junctions;
using Microsoft.AspNetCore.Mvc;

namespace FilterLists.Api.V1.Controllers
{
    public class ForksController : BaseController
    {
        private readonly SeedService seedService;

        public ForksController(SeedService seedService)
        {
            this.seedService = seedService;
        }

        [HttpGet]
        public async Task<IActionResult> Seed()
        {
            return Json(await seedService.GetAllAsync<Fork, ForkSeedDto>(
                typeof(Fork).GetProperty("UpstreamFilterListId"),
                typeof(Fork).GetProperty("ForkFilterListId")));
        }
    }
}