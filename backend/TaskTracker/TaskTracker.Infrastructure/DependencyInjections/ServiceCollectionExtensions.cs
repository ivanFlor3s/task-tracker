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
      options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));


    // Agregar los repositorios

    return services;
  }
}
