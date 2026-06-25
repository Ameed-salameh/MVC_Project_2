using Microsoft.AspNetCore.Mvc;

namespace project_2.areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
