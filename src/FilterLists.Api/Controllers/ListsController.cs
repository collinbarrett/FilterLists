using FilterLists.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace FilterLists.Api.Controllers
{
    //TODO: migrate controllers to separate projects by version, use dependency injection
    //TODO: automate URL versioning
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