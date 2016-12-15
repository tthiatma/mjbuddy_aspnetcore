using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MjBuddy.Service;

namespace MjBuddy.Web.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(ITileData tileData)
        {

        }
        [AllowAnonymous]
        public ViewResult Index()
        {

            return View();
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
