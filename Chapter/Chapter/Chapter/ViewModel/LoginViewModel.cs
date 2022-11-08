using System.ComponentModel.DataAnnotations;

namespace Chapter.ViewModel
{
    public class LoginViewModel
    { 
       
        [Required(ErrorMessage = "E-mail Requerido")]

        public string Email { get; set; }
        [Required(ErrorMessage = "Senha Requerida")]

        public string Senha { get; set; }
       
    }
}
