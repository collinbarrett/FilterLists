using System.Threading.Tasks;
using FilterLists.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace FilterLists.Api.V1.Controllers
{
    public class RulesController : BaseController
    {
        private readonly RuleService ruleService;

        public RulesController(IMemoryCache memoryCache, RuleService ruleService) : base(memoryCache) =>
            this.ruleService = ruleService;

        [HttpGet]
        public async Task<IActionResult> Index() =>
            Json(await MemoryCache.GetOrCreate("RulesController_Index", entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = MemoryCacheDurationDefault;
                return ruleService.GetCountAll();
            }));
    }
}