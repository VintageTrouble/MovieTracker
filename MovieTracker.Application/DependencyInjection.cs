using Microsoft.Extensions.DependencyInjection;

using MovieTracker.Application.Services.Authentication;

namespace MovieTracker.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();

        return services;
    }
}
