using Microsoft.AspNetCore.Mvc;

namespace TelmaBolossite.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
