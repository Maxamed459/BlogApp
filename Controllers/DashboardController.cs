using BlogApp.Data;
using BlogApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    public class DashboardController : Controller
    {
        //GET: /Dashboard/
        private readonly BlogAppContext _context;
        public DashboardController(BlogAppContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var posts = _context.BlogPosts.ToList();
            return View(posts);
        }
        public IActionResult View(int id)
        {
            var post = _context.BlogPosts.FirstOrDefault(p => p.Id == id);
            if (post == null) return NotFound();
            //var posts = _context.BlogPosts.ToList();
            return View(post);
        }

        public IActionResult NewPost()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewPost([FromForm] BlogPost model)
        {
            if (ModelState.IsValid)
            {
                _context.BlogPosts.Add(model);
                _context.SaveChanges();
                //return Json(new { success = true, message = "Data has been saved" });
                return RedirectToAction("Index");
            }

            // Collect validation errors
            var errorList = ModelState
                .Where(ms => ms.Value.Errors.Count > 0)
                .Select(ms => new
                {
                    Field = ms.Key,
                    Errors = ms.Value.Errors.Select(e => e.ErrorMessage).ToArray()
                });

            return Json(new
            {
                success = false,
                message = "Data was not saved. Validation failed.",
                errors = errorList
            });
        }

    }
}
