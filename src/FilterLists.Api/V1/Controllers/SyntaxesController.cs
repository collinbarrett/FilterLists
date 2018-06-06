using System.Threading.Tasks;
using FilterLists.Data.Entities;
using FilterLists.Services.Seed;
using FilterLists.Services.Seed.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilterLists.Api.V1.Controllers
{
    public class SyntaxesController : BaseController
    {
        public SyntaxesController(SeedService seedService) : base(seedService)
        {
        }

        [HttpGet]
        public async Task<IActionResult> Seed() => Json(await SeedService.GetAllAsync<Syntax, SyntaxSeedDto>());
    }
}