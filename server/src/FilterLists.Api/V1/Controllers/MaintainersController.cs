using System.Threading.Tasks;
using FilterLists.Api.V1.Interfaces;
using FilterLists.Data.Entities;
using FilterLists.Services.Maintainer;
using FilterLists.Services.Seed;
using FilterLists.Services.Seed.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace FilterLists.Api.V1.Controllers
{
    public class MaintainersController : BaseController, IGet, ISeed
    {
        private readonly MaintainerService maintainerService;

        public MaintainersController(IMemoryCache memoryCache, SeedService seedService,
            MaintainerService maintainerService) : base(memoryCache, seedService) =>
            this.maintainerService = maintainerService;

        [HttpGet]
        public async Task<IActionResult> GetAll() =>
            await Get(() => maintainerService.GetAllThatMaintainAnyListAsync());

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(int id) =>
            await Get(() => maintainerService.GetIfMaintainsAnyListByIdAsync(id), id);

        [HttpGet("seed")]
        public async Task<IActionResult> Seed() =>
            await Get(() => SeedService.GetAllAsync<Maintainer, MaintainerSeedDto>());
    }
}