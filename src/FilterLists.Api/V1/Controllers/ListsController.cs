using FilterLists.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace FilterLists.Api.V1.Controllers
{
    [ApiVersion("1.0")]
    [Produces("application/json")]
    [ResponseCache(CacheProfileName = "Long-Lived")]
    public class ListsController : Controller
    {
        private readonly IFilterListService filterListService;

        public ListsController(IFilterListService filterListService)
        {
            this.filterListService = filterListService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Json(filterListService.GetAllSummaries());
        }
    }
}