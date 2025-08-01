using Microsoft.EntityFrameworkCore;
using TaskTracker.Domain;

namespace TaskTracker.Infraestructure.Data;

public class AppDbContext: DbContext
{
    public DbSet<TaskItem> TaskItems { get; set; }
    public DbSet<Tag> Tags { get; set; }
    
    public AppDbContext(DbContextOptions<AppDbContext> options): base(options){
      
    }

}