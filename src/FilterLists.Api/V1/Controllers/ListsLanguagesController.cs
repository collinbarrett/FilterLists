using System.Threading.Tasks;
using FilterLists.Data.Entities.Junctions;
using FilterLists.Services.Seed;
using FilterLists.Services.Seed.Models.Junctions;
using Microsoft.AspNetCore.Mvc;

namespace FilterLists.Api.V1.Controllers
{
    public class ListsLanguagesController : BaseController
    {
        public ListsLanguagesController(SeedService seedService) : base(seedService)
        {
        }

        [HttpGet("seed")]
        public async Task<IActionResult> Seed() =>
            Json(await SeedService.GetAllAsync<FilterListLanguage, FilterListLanguageSeedDto>(
                typeof(FilterListLanguage).GetProperty("FilterListId"),
                typeof(FilterListLanguage).GetProperty("LanguageId")));
    }
}