using Lesson3.Models;
using Lesson3.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lesson3.Controllers
{
    public class HomeController(CharacterRepository characterRepository) : Controller
    {
        private const string SuffixController = "Controller";

        public IActionResult Index()
        {
            var characters = characterRepository.GetAll();
            return View(characters);
        }

        public IActionResult Details(int id)
        {
            var character = characterRepository.GetById(id);
            return View(character);
        }

        public IActionResult Update(int id)
        {
            var character = characterRepository.GetById(id);
            return View(character);
        }

        [HttpPost]
        public IActionResult Update(Character character)
        {
            characterRepository.Update(character);

            var nameAction = nameof(HomeController.Index);
            var nameController = GetControllerName(nameof(HomeController));

            return RedirectToAction(nameAction, nameController);
        }

        public IActionResult Create()
        {
            var character = new Character();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Character character)
        {
            characterRepository.Add(character);

            var nameAction = nameof(HomeController.Index);
            var nameController = GetControllerName(nameof(HomeController));

            return RedirectToAction(nameAction, nameController);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private static string GetControllerName(string nameController)
        {
            return nameController.Replace(SuffixController, string.Empty);
        }
    }
}
