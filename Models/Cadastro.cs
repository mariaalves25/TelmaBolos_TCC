using System.ComponentModel.DataAnnotations;

namespace TelmaBolos.Models
{
    public class Cadastro
    {
        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Email { get; set; }

        public string telefonecliente { get; set; }

        public string Senha { get; set; }

        public string Confirmarsenha { get; set; }
    }
}