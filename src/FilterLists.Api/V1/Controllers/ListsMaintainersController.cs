using System.Threading.Tasks;
using FilterLists.Data.Entities.Junctions;
using FilterLists.Services.Seed;
using FilterLists.Services.Seed.Models.Junctions;
using Microsoft.AspNetCore.Mvc;

namespace FilterLists.Api.V1.Controllers
{
    public class ListsMaintainersController : BaseController
    {
        public ListsMaintainersController(SeedService seedService) : base(seedService)
        {
        }

        [HttpGet("seed")]
        public async Task<IActionResult> Seed() =>
            Json(await SeedService.GetAllAsync<FilterListMaintainer, FilterListMaintainerSeedDto>(
                typeof(FilterListMaintainer).GetProperty("MaintainerId"),
                typeof(FilterListMaintainer).GetProperty("FilterListId")));
    }
}