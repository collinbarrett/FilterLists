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
        private readonly FilterListService _filterListService;

        public ListsController(SeedService seedService, FilterListService filterListService) : base(seedService)
        {
            _filterListService = filterListService;
        }

        [HttpGet]
        public async Task<IActionResult> Index() => Json(await _filterListService.GetAllSummariesAsync());

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(int id) => Json(await _filterListService.GetDetailsAsync(id));

        [HttpGet("seed")]
        public async Task<IActionResult> Seed() => Json(await SeedService.GetAllAsync<FilterList, FilterListSeedDto>());
    }
}