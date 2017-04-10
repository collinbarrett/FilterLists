using FilterLists.Services;
using Microsoft.AspNetCore.Mvc;

namespace FilterLists.Api.Controllers
{
    [Route("api/[controller]")]
    public class ListsController : Controller
    {
        private readonly IListService _listService;

        public ListsController(IListService listService)
        {
            _listService = listService;
        }

        // GET api/lists
        [HttpGet]
        public JsonResult Get()
        {
            var result = Json(_listService.GetAll());
            return result;
        }
    }
}