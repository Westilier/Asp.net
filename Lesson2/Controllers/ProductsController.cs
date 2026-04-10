using Lesson2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson2.Controllers
{
    public class ProductsController : Controller
    {
        List<Product> products = new List<Product>
            {
                new Product { Name = "Ноутбук", Price = 89990, Category = "Электроника", IsOnStorage = true },
                new Product { Name = "Офисное кресло", Price = 14990, Category = "Мебель", IsOnStorage = true, IsDiscount = true },
                new Product { Name = "Наушники", Price = 5990, Category = "Аксессуары", IsOnStorage = false, IsDiscount = true  },
                new Product { Name = "Моноблок", Price = 124990, Category = "Компьютеры", IsOnStorage = true },
                new Product { Name = "Внешний HDD 1TB", Price = 4990, Category = "Носители данных", IsOnStorage = true, IsDiscount = true  }
            };

        public IActionResult List()
        {
            return View(products);
        }
        public IActionResult Sale()
        {
            return View(products);
        }
    }
}
