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
            Json(await MemoryCache.GetOrCreate("LanguageService_Index", entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = FourHoursFromNow;
                return languageService.GetAllTargeted();
            }));

        [HttpGet("seed")]
        public async Task<IActionResult> Seed() =>
            Json(await MemoryCache.GetOrCreate("LanguagesController_Seed", entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = FourHoursFromNow;
                return SeedService.GetAllAsync<Language, LanguageSeedDto>();
            }));
    }
}