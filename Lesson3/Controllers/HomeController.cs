using Lesson3.Models;
using Lesson3.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lesson3.Controllers
{
    public class HomeController(CharacterRepository characterRepository) : Controller
    {
        public IActionResult Index()
        {
            var characters = characterRepository.GetAll();
            return View(characters);
        }

        public IActionResult Details(int id)
        {
            var product = characterRepository.GetById(id);
            return View(product);
        }
        public IActionResult Update()
        {
            var product = characterRepository.GetById(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Update(Character character)
        {
            var product = characterRepository.GetById(id);
            return View(product);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
