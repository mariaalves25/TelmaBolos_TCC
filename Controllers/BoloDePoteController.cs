using Microsoft.AspNetCore.Mvc;

namespace TelmaBolossite.Controllers
{
    public class BoloDePoteController : Controller
    {
        public IActionResult BoloDePote()
        {
            return View();
        }
    }
}
