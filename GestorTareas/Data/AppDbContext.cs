using Microsoft.EntityFrameworkCore;
using GestorTareas.Models.Entities;
using GestorTareas.Models.Interfaces;

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

        public override int SaveChanges()
        {
            SetTimestamps();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            SetTimestamps();
            return base.SaveChangesAsync(cancellationToken);
        }

        private void SetTimestamps()
        {
            var now = DateTime.UtcNow;

            foreach (var entry in ChangeTracker.Entries<IAuditableEntity>())
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.CreatedAt = now;
                    entry.Entity.UpdatedAt = now;
                }
                else if (entry.State == EntityState.Modified)
                {
                    entry.Entity.UpdatedAt = DateTime.UtcNow;

                    // Evitamos que CreatedAt se modifique por error
                    entry.Property(e => e.CreatedAt).IsModified = false;
                }
            }
        }

    }
}