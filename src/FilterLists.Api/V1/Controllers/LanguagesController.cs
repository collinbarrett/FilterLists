using System.Threading.Tasks;
using FilterLists.Data.Entities;
using FilterLists.Services.Models.Seed;
using FilterLists.Services.Services;
using Microsoft.AspNetCore.Mvc;

namespace FilterLists.Api.V1.Controllers
{
    public class LanguagesController : BaseController
    {
        private readonly SeedService seedService;

        public LanguagesController(SeedService seedService)
        {
            this.seedService = seedService;
        }

        [HttpGet]
        public async Task<IActionResult> Seed()
        {
            return Json(await seedService.GetAll<Language, LanguageSeedDto>());
        }
    }
}