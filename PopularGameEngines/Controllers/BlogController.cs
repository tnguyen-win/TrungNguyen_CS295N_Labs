using PopularGameEngines.Data;
using PopularGameEngines.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace PopularGameEngines.Controllers {
    public class BlogController : Controller {
        readonly AppDbContext context;

        public BlogController(AppDbContext c) => context = c;

        // Message(s)

        public IActionResult Index() {
            var model = context.Messages
                .Include(m => m.From)
                .ToList();

            return View(model);
        }

        // Message

        public IActionResult Post() => View();

        [HttpPost]
        public IActionResult Post(Message model) {
            Random rnd = new();

            // Fallbacks
            model.Title ??= "Random title";
            model.Body ??= "Lorem ipsum.";
            model.From.Name ??= "John Smith";

            // Originals
            model.Date = DateOnly.FromDateTime(DateTime.Now);
            model.Rating = rnd.Next(0, 10);

            context.Messages.Add(model);
            context.SaveChanges();

            return RedirectToAction("Index", new { reviewId = model.MessageId });
        }
    }
}
