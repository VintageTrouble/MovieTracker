using Microsoft.Extensions.DependencyInjection;

using MovieTracker.Application.Services.Authentication;
using MovieTracker.Application.Services.Exceptions;

namespace MovieTracker.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        services.AddScoped<IExceptionHandlerService, ExceptionHandler>();

        return services;
    }
}
