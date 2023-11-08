using Microsoft.AspNetCore.Mvc;

namespace TelmaBolossite.Controllers
{
    public class BoloDeFestaController : Controller
    {
        public IActionResult BolodeFesta()
        {
            return View();
        }
    }
}
