using Microsoft.AspNetCore.Mvc;
using project_2.Data;
using project_2.Models;

namespace project_2.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoriesController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();

        public IActionResult Index()
        {
            var categories = context.Categories.ToList();
            return View(categories);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult store(Category request)
        {
            context.Categories.Add(request);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
