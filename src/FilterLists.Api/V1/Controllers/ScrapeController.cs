using FilterLists.Services.Services;
using Microsoft.AspNetCore.Mvc;

namespace FilterLists.Api.V1.Controllers
{
    public class ScrapeController : BaseController
    {
        private readonly ScrapeService scrapeService;

        public ScrapeController(ScrapeService scrapeService)
        {
            this.scrapeService = scrapeService;
        }

        [HttpPost]
        public void Index()
        {
            //TODO: Convert endpoint into scheduled job, don't expose on prod
            //scrapeService.Scrape();
        }
    }
}