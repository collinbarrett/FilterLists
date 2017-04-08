using System.Collections.Generic;
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
        public IEnumerable<string> Get()
        {
            var lists = _listService.Lists;
            return (IEnumerable<string>) lists;
        }

        // GET api/lists/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "list";
        }

        // POST api/lists
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/lists/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/lists/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}