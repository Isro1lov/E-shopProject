using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace E_shop.Application;

public static class Extensions
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddValidatorsFromAssembly(typeof(Extensions).Assembly);
        return services;
    }
}