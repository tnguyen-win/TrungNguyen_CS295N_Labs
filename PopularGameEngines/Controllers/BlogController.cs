using PopularGameEngines.Data;
using PopularGameEngines.Models;
using Microsoft.AspNetCore.Mvc;
//using PopularGameEngines.Data;

namespace PopularGameEngines.Controllers {
    public class BlogController : Controller {
        //readonly AppDbContext context;
        readonly IRegistryRepository repository;

        public BlogController(IRegistryRepository r) => repository = r;

        // Message(s)

        public IActionResult Index() {
            var messages = repository.GetMessages();

            return View(messages);
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

            //int result =
            repository.StoreMessage(model);

            return RedirectToAction("Index", new { reviewId = model.MessageId });
        }
    }
}
