using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace HttpPractice.Controllers {
    public class DemoController : Controller {
        // GET: /<controller>/
        public IActionResult Index() => View();

        public IActionResult PageOne() => View();

        public IActionResult PageTwo(string mascot) => View("~/views/demo/pagetwo.cshtml", mascot);

        public IActionResult PageThree() => View();

        public IActionResult Quiz1() {
            Random rand = new();

            ViewBag.Number1 = rand.Next(100);
            ViewBag.Number2 = rand.Next(100);

            return View();
        }

        public IActionResult Quiz1Answer(string number1, string number2, string answer) => Content((int.Parse(number1) + int.Parse(number2)).ToString() == answer ? "right!" : "wrong :-(");

        public IActionResult Quiz2() {
            Random rand = new();
            List<int> numbers = new() {
                rand.Next(10),
                rand.Next(10)
            };

            return View(numbers);
        }

        [HttpPost]
        public IActionResult Quiz2(int number1, int number2, int answer) => Content(number1 * number2 == answer ? "right!" : "wrong :-(");
    }
}
