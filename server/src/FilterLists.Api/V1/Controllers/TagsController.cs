using System.Threading.Tasks;
using FilterLists.Api.V1.Interfaces;
using FilterLists.Data.Entities;
using FilterLists.Services.Seed;
using FilterLists.Services.Seed.Models;
using FilterLists.Services.Tag;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace FilterLists.Api.V1.Controllers
{
    public class TagsController : BaseController, IGet, ISeed
    {
        private readonly TagService tagService;

        public TagsController(IMemoryCache memoryCache, SeedService seedService, TagService tagService) :
            base(memoryCache, seedService) => this.tagService = tagService;

        [HttpGet]
        public async Task<IActionResult> GetAll() =>
            await Get(() => tagService.GetAllImplemented());

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(int id) =>
            await Get(() => tagService.GetImplementedById(id), id);

        [HttpGet("seed")]
        public async Task<IActionResult> Seed() =>
            await Get(() => SeedService.GetAllAsync<Tag, TagSeedDto>());
    }
}