using GestorTareas.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace GestorTareas.Models.Entities
{
    public class User :IAuditableEntity
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string Username { get; set; } = null!;

        [Required]
        [MaxLength(250)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(250)]
        public string Lastname { get; set; } = null!;

        [Required]
        [MaxLength(250)]
        public string Password { get; set; } = null!;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        [Required]
        [EmailAddress]
        [MaxLength(250)]
        public string Email { get; set; } = null!;

        public string NormalizedEmail { get; set; } = null!;

        // Navegación inversa
        public ICollection<Token> Tokens { get; set; } = new List<Token>();

        // Navegación inversa
        public ICollection<Task> Tasks { get; set; } = new List<Task>();
    }
}