using Microsoft.AspNetCore.Mvc;
using UnitProject2.Models;
// Author: Firaol and Xavier
//For this Project We are doing  Age Calculator.  We enter the day, month, and years, the it display  how old you are 
namespace UnitProject2.Controllers
{
    public class AgeCalculatorController : Controller
    {
        [HttpGet]
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
