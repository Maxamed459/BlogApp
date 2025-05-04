using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NewPost()
        {
            return View();
        }
    }
}
