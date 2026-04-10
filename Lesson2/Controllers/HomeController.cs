using Microsoft.AspNetCore.Mvc;

namespace Lesson2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Contacts()
        {
            return View();
        }
    }
}
