using System.Threading.Tasks;
using FilterLists.Data.Entities;
using FilterLists.Services.Seed;
using FilterLists.Services.Seed.Models;
using FilterLists.Services.Software;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace FilterLists.Api.V1.Controllers
{
    public class SoftwareController : BaseController
    {
        private readonly SoftwareService softwareService;

        public SoftwareController(IMemoryCache memoryCache, SeedService seedService, SoftwareService softwareService) :
            base(memoryCache, seedService) => this.softwareService = softwareService;

        [HttpGet]
        public async Task<IActionResult> Index() =>
            await Get(() => softwareService.GetAll());

        [HttpGet("seed")]
        public async Task<IActionResult> Seed() =>
            await Get(() => SeedService.GetAllAsync<Software, SoftwareSeedDto>());
    }
}