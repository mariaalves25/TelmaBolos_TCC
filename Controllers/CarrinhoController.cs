using Microsoft.AspNetCore.Mvc;

namespace TelmaBolossite.Controllers
{
    public class CarrinhoController : Controller
    {
        public IActionResult Carrinho()
        {
            return View();
        }
    }
}