using System.Threading.Tasks;
using FilterLists.Api.V1.Interfaces;
using FilterLists.Data.Entities;
using FilterLists.Services.List;
using FilterLists.Services.Seed;
using FilterLists.Services.Seed.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace FilterLists.Api.V1.Controllers
{
    public class ListsController : BaseController, IGet, ISeed
    {
        private readonly ListService listService;

        public ListsController(IMemoryCache memoryCache, SeedService seedService, ListService listService) :
            base(memoryCache, seedService) => this.listService = listService;

        [HttpGet]
        public async Task<IActionResult> GetAll() =>
            await Get(() => listService.GetAllAsync());

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(int id) =>
            await Get(() => listService.GetDetailsAsync(id), id);

        [HttpGet("seed")]
        public async Task<IActionResult> Seed() =>
            await Get(() => SeedService.GetAllAsync<FilterList, FilterListSeedDto>());
    }
}