using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TelmaBolos.Models;
using TelmaBolossite.Entidades;

namespace TelmaBolossite.Controllers
{
    public class CadastroController : Controller
    {
        private readonly Contexto db;

        public CadastroController(Contexto _db)
        {
            db = _db;
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(Cliente dadosTela, String Nome, string Sobrenome, string telefonecliente, string Email, string Senha, string Confirmarsenha)
        {
            db.CLIENTES.Add(dadosTela);
            db.SaveChanges();
            return RedirectToAction("Login", "Login");
        }
    }
}
