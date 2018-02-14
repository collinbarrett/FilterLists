using System.Threading.Tasks;
using FilterLists.Data.Entities.Junctions;
using FilterLists.Services.SeedService;
using FilterLists.Services.SeedService.Models.Junctions;
using Microsoft.AspNetCore.Mvc;

namespace FilterLists.Api.V1.Controllers
{
    public class SoftwareSyntaxesController : BaseController
    {
        private readonly SeedService seedService;

        public SoftwareSyntaxesController(SeedService seedService)
        {
            this.seedService = seedService;
        }

        [HttpGet]
        public async Task<IActionResult> Seed()
        {
            return Json(await seedService.GetAllAsync<SoftwareSyntax, SoftwareSyntaxSeedDto>(
                typeof(SoftwareSyntax).GetProperty("SyntaxId"),
                typeof(SoftwareSyntax).GetProperty("SoftwareId")));
        }
    }
}