using Microsoft.AspNetCore.Mvc;

namespace TelmaBolossite.Controllers
{
    public class DestaqueController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
