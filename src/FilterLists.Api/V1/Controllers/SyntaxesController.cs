using System.Threading.Tasks;
using FilterLists.Api.V1.Interfaces;
using FilterLists.Data.Entities;
using FilterLists.Services.Seed;
using FilterLists.Services.Seed.Models;
using FilterLists.Services.Syntax;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace FilterLists.Api.V1.Controllers
{
    public class SyntaxesController : BaseController, IGet, ISeed
    {
        private readonly SyntaxService syntaxService;

        public SyntaxesController(IMemoryCache memoryCache, SeedService seedService, SyntaxService syntaxService) :
            base(memoryCache, seedService) => this.syntaxService = syntaxService;

        [HttpGet]
        public async Task<IActionResult> GetAll() =>
            await Get(() => syntaxService.GetAllImplemented());

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(int id) =>
            await Get(() => syntaxService.GetImplementedById(id), id);

        [HttpGet("seed")]
        public async Task<IActionResult> Seed() =>
            await Get(() => SeedService.GetAllAsync<Syntax, SyntaxSeedDto>());
    }
}