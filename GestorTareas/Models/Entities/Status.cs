using GestorTareas.Models.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestorTareas.Models.Entities
{
    public class Status : IAuditableEntity
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string Name { get; set; } = null!;

        [Required]
        [Column(TypeName = "text")]
        public string Description { get; set; } = null!;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        // Navegación inversa
        public ICollection<Task> Tasks { get; set; } = new List<Task>();
    }
}
