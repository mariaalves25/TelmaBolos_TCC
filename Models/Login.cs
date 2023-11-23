using System.ComponentModel.DataAnnotations;

namespace TelmaBolos.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Informe o e-mail do usu�rio!")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "O e-mail est� invalido!")]
        public string emailcliente { get; set; }

        [Required(ErrorMessage = "Informe a senha!")]
        public string senhacliente { get; set; }

    }
}