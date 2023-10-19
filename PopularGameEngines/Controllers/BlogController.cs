using PopularGameEngines.Models;
using Microsoft.AspNetCore.Mvc;
//using System.CodeDom.Compiler;

namespace PopularGameEngines.Controllers {
    public class BlogController : Controller {
        public IActionResult Index() => View();

        public IActionResult Post() => View();

        [HttpPost]
        public IActionResult Post(Message modal) {
            Random rnd = new();

            // Fallbacks
            modal.Title ??= "Random title";
            modal.Text ??= "Lorem ipsum.";
            modal.From.Name ??= "John Smith";

            // Originals
            modal.Date = DateOnly.FromDateTime(DateTime.Now);
            modal.Rating = rnd.Next(0, 10);

            return View("Index", modal);
        }
    }
}
