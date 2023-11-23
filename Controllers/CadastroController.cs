using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TelmaBolos.Models;

namespace TelmaBolossite.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CriaConta([Bind("Nome, Sobrenome, telefonecliente, Email, Senha, Confirmarsenha")] Cadastro dadosTela, String Nome, string Sobrenome, string telefonecliente, string Email, string Senha, string Confirmarsenha)
        {
            if (ModelState.IsValid)
            {

                _db.Add(dadosTela);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Login));
            }
            return View("CriaConta");
        }
    }
}
