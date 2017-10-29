using System;
using System.Collections.Generic;
using System.Linq;
using FilterLists.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace FilterLists.Api.Controllers
{
    [Route("v1/[controller]")]
    [Produces("application/json")]
    public class ListsController : Controller
    {
        private static readonly string[] Summaries =
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly IFilterListService filterListService;

        public ListsController(IFilterListService filterListService)
        {
            this.filterListService = filterListService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Json(filterListService.GetAll());
        }

        [HttpGet("[action]")]
        public IEnumerable<WeatherForecast> WeatherForecasts()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                DateFormatted = DateTime.Now.AddDays(index).ToString("d"),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });
        }

        public class WeatherForecast
        {
            public string DateFormatted { get; set; }
            public int TemperatureC { get; set; }
            public string Summary { get; set; }
            public int TemperatureF => 32 + (int) (TemperatureC / 0.5556);
        }
    }
}