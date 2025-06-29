using Microsoft.EntityFrameworkCore;
using TaskTracker.Core.Entities;
using TaskTracker.Core.Entities.Bases;

namespace TaskTracker.Infrastructure;

public class AppDbContext : DbContext
{
  // DbSet properties for your entities
  public DbSet<TaskItem> Tasks { get; set; }
  public DbSet<Tag> Tags { get; set; }
  public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
  {
  }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);
    modelBuilder.Entity<TaskItem>().ToTable("Tasks");
    modelBuilder.Entity<Tag>().ToTable("Tags");
  }


  public override int SaveChanges()
  {
    ApplyAuditing();
    return base.SaveChanges();
  }

  public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
  {
    ApplyAuditing();
    return await base.SaveChangesAsync(cancellationToken);
  }

  private void ApplyAuditing()
  {
    var entries = ChangeTracker.Entries()
      .Where(e => e is { Entity: AuditEntity, State: EntityState.Added or EntityState.Modified or EntityState.Deleted });

    foreach (var entry in entries)
    {
      var entity = (AuditEntity)entry.Entity;

      if (entry.State == EntityState.Added)
      {
        entity.CreatedAt = DateTime.UtcNow;
      }
      else if (entry.State == EntityState.Modified)
      {
        entity.UpdatedAt = DateTime.UtcNow;
      }
      else if (entry.State == EntityState.Deleted)
      {
        entity.IsDeleted = true;
        entity.DeletedAt = DateTime.UtcNow;
        entry.State = EntityState.Modified; // Change state to Modified to avoid actual deletion
      }
    }
  }

}
