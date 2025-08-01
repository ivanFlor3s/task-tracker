using Microsoft.Extensions.DependencyInjection;
using TaskTracker.Transversal.Mapper;

namespace TaskTracker.Transversal.Common;

public static class ConfigureServices
{
    public static IServiceCollection AddTransversalServices(this IServiceCollection services)
    {
        services.AddAutoMapper(cfg => { }, typeof(AppProfiler).Assembly);
        return services;
    }
}