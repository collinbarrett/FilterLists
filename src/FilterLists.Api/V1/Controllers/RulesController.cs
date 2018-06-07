using System.Threading.Tasks;
using FilterLists.Services;
using Microsoft.AspNetCore.Mvc;

namespace FilterLists.Api.V1.Controllers
{
    public class RulesController : BaseController
    {
        private readonly RuleService _ruleService;

        public RulesController(RuleService ruleService)
        {
            _ruleService = ruleService;
        }

        [HttpGet]
        public async Task<IActionResult> Index() => Json(new {Count = await _ruleService.GetCountAllActiveRules()});
    }
}