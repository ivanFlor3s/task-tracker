using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TaskTracker.Infraestructure.Data;
using TaskTracker.Infraestructure.Interface;

namespace TaskTracker.Infraestructure.Repository;

public static class ConfigureServices
{
    
    public static IServiceCollection AddInfraServices(this IServiceCollection services)
    {

        services.AddScoped<ITaskRepository, TaskRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        // Get connection string from configuration
        var serviceProvider = services.BuildServiceProvider();
        var configuration = serviceProvider.GetRequiredService<IConfiguration>();
        var connectionString = configuration.GetConnectionString("DefaultConnection");


        services.AddDbContext<AppDbContext>(opts =>
        {
            opts.UseNpgsql(connectionString);

            var environment = serviceProvider.GetRequiredService<IHostEnvironment>();
            if (!environment.IsProduction())
            {
                opts.EnableSensitiveDataLogging()
                    .EnableDetailedErrors();
            }
        });
        
        // //Run Migration
        // using var scope = serviceProvider.CreateScope();
        // var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
        // dbContext.Database.Migrate();

        return services;
    }
}