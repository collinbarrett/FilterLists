using System.Threading.Tasks;
using FilterLists.Data.Entities;
using FilterLists.Services.Seed;
using FilterLists.Services.Seed.Models;
using FilterLists.Services.Tag;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace FilterLists.Api.V1.Controllers
{
    public class TagsController : BaseController
    {
        private readonly TagService tagService;

        public TagsController(IMemoryCache memoryCache, SeedService seedService, TagService tagService) :
            base(memoryCache, seedService) => this.tagService = tagService;

        [HttpGet]
        public async Task<IActionResult> Index() =>
            await Get(() => tagService.GetAll());

        [HttpGet("seed")]
        public async Task<IActionResult> Seed() =>
            await Get(() => SeedService.GetAllAsync<Tag, TagSeedDto>());
    }
}