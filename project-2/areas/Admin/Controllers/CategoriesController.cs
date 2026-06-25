using Microsoft.AspNetCore.Mvc;
using project_2.Data;

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
    }
}
