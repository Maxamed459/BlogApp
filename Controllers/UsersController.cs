using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult RegisterUser()
        {
            return View();
        }
    }
}
