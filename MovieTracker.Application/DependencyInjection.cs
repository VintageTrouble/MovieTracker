using MediatR;

using Microsoft.Extensions.DependencyInjection;

using MovieTracker.Application.Services.Exceptions;

namespace MovieTracker.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(typeof(DependencyInjection).Assembly);
        services.AddScoped<IExceptionHandlerService, ExceptionHandler>();

        return services;
    }
}
