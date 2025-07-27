using Microsoft.Extensions.DependencyInjection;
using TaskTracker.Application.Interface;

namespace TaskTracker.Application.Main;

public static class ConfigureServices
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<ITaskApplication, TaskApplication>();
        return services;
    }
}