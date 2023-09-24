using Microsoft.AspNetCore.Mvc;
using System.Data;
using TipCalculator.Models;

namespace TipCalculator.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Fifteen = 0;
            ViewBag.Twenty = 0;
            // ViewBag should have a capital B
            ViewBag.TwentyFive = 0;
            //added a return to the line below so it returns the View()
            return View();
        }

        [HttpPost]
        public IActionResult Index(Calculator calc)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Fifteen = calc.CalculateTip(0.15);
                ViewBag.Twenty = calc.CalculateTip(0.20);
                ViewBag.TwentyFive = calc.CalculateTip(0.25);
            }
            else
            {
                ViewBag.Fifteen = 0;
                ViewBag.Twenty = 0;
                ViewBag.TwentyFive = 0;
            }
            return View(calc);
        }
    }
}