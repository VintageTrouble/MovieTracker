using Microsoft.Extensions.DependencyInjection;

using MovieTracker.Application.Services.Authentication;

namespace MovieTracker.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();

        return services;
    }
}

