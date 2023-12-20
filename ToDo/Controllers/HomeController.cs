using Microsoft.AspNetCore.Mvc;

namespace ToDo.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public async Task<IActionResult> Index()
        {
            ViewBag.Title = "Home";

            return View();
        }


    }
}
