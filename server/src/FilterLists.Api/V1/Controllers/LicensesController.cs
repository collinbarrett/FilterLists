using System.Threading.Tasks;
using FilterLists.Api.V1.Interfaces;
using FilterLists.Data.Entities;
using FilterLists.Services.License;
using FilterLists.Services.Seed;
using FilterLists.Services.Seed.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace FilterLists.Api.V1.Controllers
{
    public class LicensesController : BaseController, IGet, ISeed
    {
        private readonly LicenseService licenseService;

        public LicensesController(IMemoryCache memoryCache, SeedService seedService, LicenseService licenseService) :
            base(memoryCache, seedService) => this.licenseService = licenseService;

        [HttpGet]
        public async Task<IActionResult> GetAll() =>
            await Get(() => licenseService.GetAllImplementedAsync());

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(int id) =>
            await Get(() => licenseService.GetImplementedByIdAsync(id), id);

        [HttpGet("seed")]
        public async Task<IActionResult> Seed() =>
            await Get(() => SeedService.GetAllAsync<License, LicenseSeedDto>());
    }
}