using Microsoft.AspNetCore.Mvc;
using NickPixPlus.Models;
namespace NickPixPlus.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ContactModel model)
        {
            return View(model);
        }
    }
}
