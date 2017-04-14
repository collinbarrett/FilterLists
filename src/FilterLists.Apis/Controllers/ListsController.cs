using FilterLists.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace FilterLists.Api.Controllers
{
    //TODO: migrate controllers to separate projects by version, use dependency injection
    //TODO: automate URL versioning
    [Route("v1/[controller]")]
    public class ListsController : Controller
    {
        private readonly IListService _listService;

        public ListsController(IListService listService)
        {
            _listService = listService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = Json(_listService.GetAll());
            return result;
        }
    }
}