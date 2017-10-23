using FilterLists.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace FilterLists.Api.Controllers
{
    //TODO: migrate controllers to separate projects by version, use dependency injection
    //TODO: automate URL versioning
    [Route("v1/[controller]")]
    public class ListsController : Controller
    {
        private readonly IListService listService;

        public ListsController(IListService listService)
        {
            this.listService = listService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Json(listService.GetAll());
        }
    }
}