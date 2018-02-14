using System.Threading.Tasks;
using FilterLists.Data.Entities.Junctions;
using FilterLists.Services.SeedService;
using FilterLists.Services.SeedService.Models.Junctions;
using Microsoft.AspNetCore.Mvc;

namespace FilterLists.Api.V1.Controllers
{
    public class ListsLanguagesController : BaseController
    {
        private readonly SeedService seedService;

        public ListsLanguagesController(SeedService seedService)
        {
            this.seedService = seedService;
        }

        [HttpGet]
        public async Task<IActionResult> Seed()
        {
            return Json(await seedService.GetAllAsync<FilterListLanguage, FilterListLanguageSeedDto>(
                typeof(FilterListLanguage).GetProperty("FilterListId"),
                typeof(FilterListLanguage).GetProperty("LanguageId")));
        }
    }
}