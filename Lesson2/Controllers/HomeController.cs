using Lesson2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

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
