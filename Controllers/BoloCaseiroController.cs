using Microsoft.AspNetCore.Mvc;

namespace TelmaBolossite.Controllers
{
    public class BoloCaseiroController : Controller
    {
        private readonly Contexto db;

        public BoloCaseiroController(Contexto _db)
        {
            db = _db;
        }

        public IActionResult BoloCaseiro()
        {
            return View();
        }
    }
}
