using System.Threading.Tasks;
using FilterLists.Data.Entities.Junctions;
using FilterLists.Services.SeedService;
using FilterLists.Services.SeedService.Models.Junctions;
using Microsoft.AspNetCore.Mvc;

namespace FilterLists.Api.V1.Controllers
{
    public class ListsMaintainersController : BaseController
    {
        private readonly SeedService seedService;

        public ListsMaintainersController(SeedService seedService)
        {
            this.seedService = seedService;
        }

        [HttpGet]
        public async Task<IActionResult> Seed()
        {
            return Json(await seedService.GetAllAsync<FilterListMaintainer, FilterListMaintainerSeedDto>(
                typeof(FilterListMaintainer).GetProperty("MaintainerId"),
                typeof(FilterListMaintainer).GetProperty("FilterListId")));
        }
    }
}