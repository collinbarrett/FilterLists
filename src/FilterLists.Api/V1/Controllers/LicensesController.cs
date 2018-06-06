using System.Threading.Tasks;
using FilterLists.Data.Entities;
using FilterLists.Services.Seed;
using FilterLists.Services.Seed.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilterLists.Api.V1.Controllers
{
    public class LicensesController : BaseController
    {
        public LicensesController(SeedService seedService) : base(seedService)
        {
        }

        [HttpGet("seed")]
        public async Task<IActionResult> Seed() => Json(await SeedService.GetAllAsync<License, LicenseSeedDto>());
    }
}