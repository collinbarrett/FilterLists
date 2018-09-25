using System.Threading.Tasks;
using FilterLists.Data.Entities;
using FilterLists.Services.FilterList;
using FilterLists.Services.Seed;
using FilterLists.Services.Seed.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace FilterLists.Api.V1.Controllers
{
    public class ListsController : BaseController
    {
        private readonly FilterListService filterListService;

        public ListsController(IMemoryCache memoryCache, SeedService seedService, FilterListService filterListService) :
            base(memoryCache, seedService) => this.filterListService = filterListService;

        [HttpGet]
        public async Task<IActionResult> Index() =>
            CoalesceNotFound(Json(await MemoryCache.GetOrCreate("ListsController_Index", entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = MemoryCacheExpirationDefault;
                return filterListService.GetAllAsync();
            })));

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(int id) =>
            CoalesceNotFound(Json(await MemoryCache.GetOrCreate("ListsController_GetById_" + id, entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = MemoryCacheExpirationDefault;
                return filterListService.GetDetailsAsync((uint)id);
            })));

        [HttpGet("seed")]
        public async Task<IActionResult> Seed() =>
            CoalesceNotFound(Json(await MemoryCache.GetOrCreate("ListsController_Seed", entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = MemoryCacheExpirationDefault;
                return SeedService.GetAllAsync<FilterList, FilterListSeedDto>();
            })));
    }
}