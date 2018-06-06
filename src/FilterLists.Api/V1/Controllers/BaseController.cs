using FilterLists.Services.Seed;
using Microsoft.AspNetCore.Mvc;

namespace FilterLists.Api.V1.Controllers
{
    [ApiVersion("1.0")]
    public class BaseController : Controller
    {
        protected readonly SeedService SeedService;

        protected BaseController(SeedService seedService)
        {
            SeedService = seedService;
        }
    }
}