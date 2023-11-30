using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NickPixPlus.Models;
using System.Diagnostics;

namespace NickPixPlus.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult FAQ()
        {
            return View();
        }

        public IActionResult Events()
        {
            return View();
        }

        // Set Session data, redirect to Home/Tools
        [HttpPost]
        public IActionResult Tools(MySession model)
        {
            HttpContext.Session.SetString("FirstName", "Nick");
            HttpContext.Session.SetString("LastName", "Tysh");
            HttpContext.Session.SetString("Course", "IT2030");
            HttpContext.Session.SetInt32("FavNum", 5);

            return RedirectToAction("Tools");
        }
        // Get Session data, return View with the model
        public IActionResult Tools()
        {
            var model = new MySession
            {
                FirstName = HttpContext.Session.GetString("FirstName"),
                LastName = HttpContext.Session.GetString("LastName"),
                Course = HttpContext.Session.GetString("Course"),
                FavNum = HttpContext.Session.GetInt32("FavNum")
            };

            return View(model);
        }

        // Clear Session data, redirect to Home/Tools
        public IActionResult ClearSession()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Tools");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}