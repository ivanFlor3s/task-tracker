using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TaskTracker.Infrastructure.DependencyInjections;

public static class ServiceCollectionExtensions
{
  public static IServiceCollection AddInfrastructureServices(
    this IServiceCollection services,
    IConfiguration configuration)
  {
    // Agregar EF Core con PostgreSQL
    services.AddDbContext<AppDbContext>(options =>
      options.UseNpgsql("Host=db;Database=tasktracker_db;Username=tasktracker;Password=todo789"));


    // Agregar los repositorios

    return services;
  }
}
