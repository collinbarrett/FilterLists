using System.Threading.Tasks;
using FilterLists.Data.Entities;
using FilterLists.Services.Language;
using FilterLists.Services.Seed;
using FilterLists.Services.Seed.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace FilterLists.Api.V1.Controllers
{
    public class LanguagesController : BaseController
    {
        private readonly LanguageService languageService;

        public LanguagesController(IMemoryCache memoryCache, SeedService seedService, LanguageService languageService) :
            base(memoryCache, seedService) => this.languageService = languageService;

        [HttpGet]
        public async Task<IActionResult> Index() =>
            await Get(() => languageService.GetAllTargetedAsync());

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(int id) =>
            await Get(() => languageService.GetTargetedByIdAsync(id), id);

        [HttpGet("seed")]
        public async Task<IActionResult> Seed() =>
            await Get(() => SeedService.GetAllAsync<Language, LanguageSeedDto>());
    }
}