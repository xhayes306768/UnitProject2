using Microsoft.AspNetCore.Mvc;

namespace UnitProject2.Controllers
{
    public class AgeCalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
