using Microsoft.AspNetCore.Mvc;

namespace Boake_BackEnd.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
