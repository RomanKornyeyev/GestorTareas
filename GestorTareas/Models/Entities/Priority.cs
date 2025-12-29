using System.ComponentModel.DataAnnotations;

namespace GestorTareas.Models.Entities
{
    public class Priority
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Name { get; set; } = null!;

        [Required]
        public int LevelPriority { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime ModifiedAt { get; set; } = DateTime.UtcNow;

        // Navegación inversa
        public ICollection<Task> Tasks { get; set; } = new List<Task>();
    }
}