using System.Threading.Tasks;
using FilterLists.Data.Entities;
using FilterLists.Services.FilterList;
using FilterLists.Services.Seed;
using FilterLists.Services.Seed.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilterLists.Api.V1.Controllers
{
    public class ListsController : BaseController
    {
        private readonly FilterListService filterListService;

        public ListsController(SeedService seedService, FilterListService filterListService) : base(seedService) =>
            this.filterListService = filterListService;

        [HttpGet]
        public async Task<IActionResult> Index() => Json(await filterListService.GetAllSummariesAsync());

        [HttpGet]
        [Route("{id}")]
        //TODO: respond with appropriate exception if negative id queried
        public async Task<IActionResult> GetById(int id) => Json(await filterListService.GetDetailsAsync((uint) id));

        [HttpGet("seed")]
        public async Task<IActionResult> Seed() => Json(await SeedService.GetAllAsync<FilterList, FilterListSeedDto>());
    }
}