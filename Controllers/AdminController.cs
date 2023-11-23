using Microsoft.AspNetCore.Mvc;

namespace TelmaBolossite.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
