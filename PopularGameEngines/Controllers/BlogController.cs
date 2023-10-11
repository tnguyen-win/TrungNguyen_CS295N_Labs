using Microsoft.AspNetCore.Mvc;

namespace PopularGameEngines.Controllers {
    public class BlogController : Controller {
        public IActionResult Index() => View();
    }
}
