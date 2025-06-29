using Microsoft.EntityFrameworkCore;
using TaskTracker.Core.Entities;

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



}
