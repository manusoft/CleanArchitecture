using Microsoft.Extensions.DependencyInjection;

namespace MyApp.Application;

public static class DependecyInjection
{
    public static IServiceCollection AddApplicationService(this IServiceCollection services)
    {
        return services;
    }
}
