using Microsoft.AspNetCore.Mvc;

namespace FilterLists.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}