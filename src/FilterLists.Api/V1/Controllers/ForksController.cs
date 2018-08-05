using System.Threading.Tasks;
using FilterLists.Data.Entities.Junctions;
using FilterLists.Services.Seed;
using FilterLists.Services.Seed.Models.Junctions;
using Microsoft.AspNetCore.Mvc;

namespace FilterLists.Api.V1.Controllers
{
    public class ForksController : BaseController
    {
        public ForksController(SeedService seedService) : base(seedService)
        {
        }

        [HttpGet("seed")]
        public async Task<IActionResult> Seed() =>
            Json(await SeedService.GetAllAsync<Fork, ForkSeedDto>(typeof(Fork).GetProperty("UpstreamFilterListId"),
                typeof(Fork).GetProperty("ForkFilterListId")));
    }
}