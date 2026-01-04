using Microsoft.EntityFrameworkCore;
using GestorTareas.Models.Entities;

namespace GestorTareas.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }

        public DbSet<Models.Entities.User> Users { get; set; }
        public DbSet<GestorTareas.Models.Entities.Task> Task { get; set; }
        public DbSet<GestorTareas.Models.Entities.Priority> Priority { get; set; }
        public DbSet<GestorTareas.Models.Entities.Status> Status { get; set; }
    }
}