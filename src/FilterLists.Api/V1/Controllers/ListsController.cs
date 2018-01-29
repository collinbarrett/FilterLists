using System.Threading.Tasks;
using FilterLists.Data.Entities;
using FilterLists.Services.Models.Seed;
using FilterLists.Services.Services;
using Microsoft.AspNetCore.Mvc;

namespace FilterLists.Api.V1.Controllers
{
    public class ListsController : BaseController
    {
        private readonly FilterListService filterListService;
        private readonly SeedService seedService;

        public ListsController(SeedService seedService, FilterListService filterListService)
        {
            this.seedService = seedService;
            this.filterListService = filterListService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return Json(await filterListService.GetAllSummariesAsync());
        }

        [HttpGet]
        public async Task<IActionResult> Seed()
        {
            return Json(await seedService.GetAllAsync<FilterList, FilterListSeedDto>());
        }
    }
}