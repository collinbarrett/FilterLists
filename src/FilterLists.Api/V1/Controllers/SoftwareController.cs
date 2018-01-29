using System.Threading.Tasks;
using FilterLists.Data.Entities;
using FilterLists.Services.Models.Seed;
using FilterLists.Services.Services;
using Microsoft.AspNetCore.Mvc;

namespace FilterLists.Api.V1.Controllers
{
    public class SoftwareController : BaseController
    {
        private readonly SeedService seedService;

        public SoftwareController(SeedService seedService)
        {
            this.seedService = seedService;
        }

        [HttpGet]
        public async Task<IActionResult> Seed()
        {
            return Json(await seedService.GetAllAsync<Software, SoftwareSeedDto>());
        }
    }
}