using System.ComponentModel.DataAnnotations;

namespace GestorTareas.Models
{
    public class UpdateUserViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(250)]
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(250)]
        public string Name { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(250)]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [EmailAddress(ErrorMessage = "Se debe introducir un email válido")]
        public string Email { get; set; } = string.Empty;
    }
}
