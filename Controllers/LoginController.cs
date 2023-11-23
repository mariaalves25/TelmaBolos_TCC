using Microsoft.AspNetCore.Mvc;
using TelmaBolossite.Entidades;

namespace TelmaBolossite.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Continuar(Login login, string emailcliente, string senhacliente)
        {
            if (emailcliente == "telmabolosadm@gmail.com" && senhacliente == "123456")
            {
                return Redirect("/Produtos/Index");
            }
            return View("Login");
        }
    }
}
