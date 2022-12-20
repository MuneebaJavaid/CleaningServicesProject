using SaafCleaningProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace SaafCleaningProject.Controllers
{
    public class FirstController : Controller
    {

        public ActionResult Cot()
        {
            return View();
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult Services()
        {
            return View();
        }
    }
}
