using PopularGameEngines.Models;
using Microsoft.AspNetCore.Mvc;
using System.CodeDom.Compiler;

namespace PopularGameEngines.Controllers {
    public class BlogController : Controller {
        public IActionResult Index() => View();

        public IActionResult Post() => View();

        [HttpPost]
        public IActionResult Post(Message model) {
            Random random = new Random();
            int rnd = random.Next(0, 5);

            // Fallbacks
            model.Title ??= "Random title";
            model.Text ??= "Lorem ipsum.";
            model.Author ??= "John Smith";

            // Originals
            model.Date = DateOnly.FromDateTime(DateTime.Now);
            for (var i = 0; i < rnd; i++) model.Rating += "⭐";

            return View("Index", model);
        }
    }
}
