using System.ComponentModel.DataAnnotations;

namespace GestorTareas.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [EmailAddress(ErrorMessage = "Se debe introducir un email válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Password { get; set; }
    }
}
