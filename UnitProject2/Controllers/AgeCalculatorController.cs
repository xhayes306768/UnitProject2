using Microsoft.AspNetCore.Mvc;
using UnitProject2.Models;

namespace UnitProject2.Controllers
{
    public class AgeCalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CalculateAge(Birthdate model)
        {
            if (ModelState.IsValid)
            {
                int age = model.CalculateAge();
                ViewBag.Age = age;
                return View("AgeResult");
            }

            return View("Index", model);
        }
    }
}
