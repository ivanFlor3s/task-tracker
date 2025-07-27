using Microsoft.Extensions.DependencyInjection;
using TaskTracker.Domain.Interfaces;

namespace TaskTracker.Domain.Core;

public static class ConfigureServices
{
    
    public static IServiceCollection AddDomainServices(this IServiceCollection services)
    {
        services.AddScoped<ITaskDomain, TaskDomain>();
        return services;
    }
}