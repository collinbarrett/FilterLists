using FilterLists.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace FilterLists.Api.V1.Controllers
{
    [ApiVersion("1.0")]
    [Produces("application/json")]
    public class ListsController : Controller
    {
        private readonly IFilterListService filterListService;

        public ListsController(IFilterListService filterListService)
        {
            this.filterListService = filterListService;
        }

        [HttpGet]
        [ResponseCache(CacheProfileName = "Long-Lived")]
        public IActionResult Get()
        {
            return Json(filterListService.GetAllSummaries());
        }
    }
}