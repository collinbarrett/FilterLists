using System;
using System.Threading.Tasks;
using FilterLists.Data.Entities;
using FilterLists.Services.Models.Seed;
using FilterLists.Services.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace FilterLists.Api.V1.Controllers
{
    public class EntityController : BaseController
    {
        protected readonly SeedService SeedService;

        protected EntityController(IMemoryCache memoryCache, SeedService seedService) : base(memoryCache)
        {
            SeedService = seedService;
        }

        [HttpGet]
        public async Task<IActionResult> Seed()
        {
            var controllerName = ControllerContext.RouteData.Values["controller"].ToString();
            return await GetSeed(controllerName);
        }

        private async Task<IActionResult> GetSeed(string controllerName)
        {
            switch (controllerName)
            {
                case "lists":
                    return await MemoryCache.GetOrCreateAsync(CacheKeys.Entry, async entry =>
                    {
                        entry.SlidingExpiration = TimeSpan.FromSeconds(3);
                        return Json(await SeedService.GetAll<FilterList, FilterListSeedDto>());
                    });
                case "languages":
                    return await MemoryCache.GetOrCreateAsync(CacheKeys.Entry, async entry =>
                    {
                        entry.SlidingExpiration = TimeSpan.FromSeconds(3);
                        return Json(await SeedService.GetAll<Language, LanguageSeedDto>());
                    });
                case "licenses":
                    return await MemoryCache.GetOrCreateAsync(CacheKeys.Entry, async entry =>
                    {
                        entry.SlidingExpiration = TimeSpan.FromSeconds(3);
                        return Json(await SeedService.GetAll<License, LicenseSeedDto>());
                    });
                case "maintainers":
                    return await MemoryCache.GetOrCreateAsync(CacheKeys.Entry, async entry =>
                    {
                        entry.SlidingExpiration = TimeSpan.FromSeconds(3);
                        return Json(await SeedService.GetAll<Maintainer, MaintainerSeedDto>());
                    });
                case "software":
                    return await MemoryCache.GetOrCreateAsync(CacheKeys.Entry, async entry =>
                    {
                        entry.SlidingExpiration = TimeSpan.FromSeconds(3);
                        return Json(await SeedService.GetAll<Software, SoftwareSeedDto>());
                    });
                case "syntaxes":
                    return await MemoryCache.GetOrCreateAsync(CacheKeys.Entry, async entry =>
                    {
                        entry.SlidingExpiration = TimeSpan.FromSeconds(3);
                        return Json(await SeedService.GetAll<Syntax, SyntaxSeedDto>());
                    });
                default:
                    return await Task.FromResult(NotFound());
            }
        }
    }
}