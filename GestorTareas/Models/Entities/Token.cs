using GestorTareas.Models.Entities;
using GestorTareas.Models.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestorTareas.Models.Entities
{
    public class Token : IAuditableEntity
    {
        public int Id { get; set; }

        // FK
        [ForeignKey("User")]
        public int UserId { get; set; }

        // Propiedad de navegación
        public User User { get; set; } = null!;

        [Required]
        [MaxLength(250)]
        public string Value { get; set; } = null!;

        public DateTime ExpirationDate { get; set; } = DateTime.UtcNow;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}