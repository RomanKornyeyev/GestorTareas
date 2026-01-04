using GestorTareas.Models.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestorTareas.Models.Entities
{
    public class Task : IAuditableEntity
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string Title { get; set; } = null!;

        [MaxLength(250)]
        public string Subtitle { get; set; } = null!;

        [MaxLength(250)]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [Column(TypeName = "text")]
        public string Text { get; set; } = null!;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; } = null!;

        [ForeignKey("Status")]
        public int StatusId { get; set; }
        public Status Status { get; set; } = null!;

        [ForeignKey("Priority")]
        public int PriorityId { get; set; }
        public Priority Priority { get; set; } = null!;
    }
}
