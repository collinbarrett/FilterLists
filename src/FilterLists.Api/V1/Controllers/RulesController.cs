using System.Threading.Tasks;
using FilterLists.Services;
using Microsoft.AspNetCore.Mvc;

namespace FilterLists.Api.V1.Controllers
{
    public class RulesController : BaseController
    {
        private readonly RuleService ruleService;

        public RulesController(RuleService ruleService)
        {
            this.ruleService = ruleService;
        }

        [HttpGet]
        public async Task<IActionResult> Index() => Json(await ruleService.GetCountAll());
    }
}