using System.Threading.Tasks;
using FilterLists.Api.V1.Interfaces;
using FilterLists.Data.Entities.Junctions;
using FilterLists.Services.Seed;
using FilterLists.Services.Seed.Models.Junctions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace FilterLists.Api.V1.Controllers
{
    public class SoftwareSyntaxesController : BaseController, ISeed
    {
        public SoftwareSyntaxesController(IMemoryCache memoryCache, SeedService seedService)
            : base(memoryCache, seedService)
        {
        }

        [HttpGet("seed")]
        public async Task<IActionResult> Seed() =>
            await Get(() => SeedService.GetAllAsync<SoftwareSyntax, SoftwareSyntaxSeedDto>(
                typeof(SoftwareSyntax).GetProperty("SyntaxId"),
                typeof(SoftwareSyntax).GetProperty("SoftwareId")));
    }
}