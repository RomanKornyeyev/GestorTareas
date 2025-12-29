using Microsoft.EntityFrameworkCore;

namespace GestorTareas.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }

        public DbSet<Models.Entities.User> Users { get; set; }
    }
}