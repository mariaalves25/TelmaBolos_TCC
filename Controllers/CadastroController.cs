using Microsoft.AspNetCore.Mvc;

namespace TelmaBolossite.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Cadastro()
        {
            return View();
        }
    }
}
