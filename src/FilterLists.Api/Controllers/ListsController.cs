using FilterLists.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace FilterLists.Api.Controllers
{
    [Produces("application/json")]
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