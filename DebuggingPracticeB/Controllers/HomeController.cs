using Microsoft.AspNetCore.Mvc;

namespace HttpPractice.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() => View();

        [HttpPost]
        public IActionResult HomeTown(string state, string city) => Content($"State: {state}, City: {city}");

        [HttpPost]
        public IActionResult Vacation(string location, string activity, string clothing) => Content($"Location: {location}, Activity: {activity}, What to wear: {clothing}");

        [HttpPost]
        public IActionResult Reading(string genre, string author, string book) => Content($"Genre: {genre}, Author: {author}, Book: {book}");
    }
}
