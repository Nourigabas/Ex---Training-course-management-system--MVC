using Microsoft.AspNetCore.Mvc;

namespace Ex___Training_course_management_system__MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}