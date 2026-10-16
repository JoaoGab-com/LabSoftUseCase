using Microsoft.AspNetCore.Mvc;

namespace AppTask.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
