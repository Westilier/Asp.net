using Lesson1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var person = new Person
            {
                Name = "Влад",
                Surname = "Гаврилов",
                Age = 18,
            };
            return View(person);
        }
    }
}
