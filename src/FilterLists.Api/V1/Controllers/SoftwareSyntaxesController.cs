using System.Threading.Tasks;
using FilterLists.Data.Entities.Junctions;
using FilterLists.Services.Seed;
using FilterLists.Services.Seed.Models.Junctions;
using Microsoft.AspNetCore.Mvc;

namespace FilterLists.Api.V1.Controllers
{
    public class SoftwareSyntaxesController : BaseController
    {
        public SoftwareSyntaxesController(SeedService seedService) : base(seedService)
        {
        }

        [HttpGet]
        public async Task<IActionResult> Seed() =>
            Json(await SeedService.GetAllAsync<SoftwareSyntax, SoftwareSyntaxSeedDto>(
                typeof(SoftwareSyntax).GetProperty("SyntaxId"), typeof(SoftwareSyntax).GetProperty("SoftwareId")));
    }
}