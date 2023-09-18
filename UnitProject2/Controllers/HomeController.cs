using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UnitProject2.Models;
// This is the controller that handles ouir get and post actions.

namespace UnitProject2.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        

        // Here is our CalculateAge Method that handles the form submission,
        //calculates age and displays the result in our Age result view

        //If info is correct return age view, If not return the index
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