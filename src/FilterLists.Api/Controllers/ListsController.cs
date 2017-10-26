using FilterLists.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace FilterLists.Api.Controllers
{
    [Route("v1/[controller]")]
    [Produces("application/json")]
    public class ListsController : Controller
    {
        private readonly IFilterListService filterListService;

        public ListsController(IFilterListService filterListService)
        {
            this.filterListService = filterListService;
        }

        /// <summary>
        /// Get Lists
        /// </summary>
        /// <returns>All FilterLists</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Json(filterListService.GetAll());
        }
    }
}