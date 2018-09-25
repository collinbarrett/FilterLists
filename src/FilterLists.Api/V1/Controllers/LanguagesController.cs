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
            Json(await MemoryCache.GetOrCreate("LanguagesController_Index", entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = MemoryCacheExpirationDefault;
                return languageService.GetAllTargetedAsync();
            }));

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(int id) =>
            Json(await MemoryCache.GetOrCreate("LanguagesController_GetById_" + id, entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = MemoryCacheExpirationDefault;
                return languageService.GetTargetedByIdAsync(id);
            }));

        [HttpGet("seed")]
        public async Task<IActionResult> Seed() =>
            Json(await MemoryCache.GetOrCreate("LanguagesController_Seed", entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = MemoryCacheExpirationDefault;
                return SeedService.GetAllAsync<Language, LanguageSeedDto>();
            }));
    }
}