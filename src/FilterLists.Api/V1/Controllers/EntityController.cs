using System;
using FilterLists.Services.Models;
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
        public IActionResult Seed()
        {
            var controllerName = ControllerContext.RouteData.Values["controller"].ToString();
            return MemoryCache.GetOrCreate(CacheKeys.Entry, entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(86400);
                //TODO: GetAll<T>() by seed type of request controller
                return Json(SeedService.GetAll<FilterListSeedDto>());
            });
        }
    }
}