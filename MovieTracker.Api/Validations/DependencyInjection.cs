using FluentValidation;

using MovieTracker.Api.Validations.Authentication;
using MovieTracker.Contracts.Authentication;

namespace MovieTracker.Api.Validations;

public static class DependencyInjection
{
    public static IServiceCollection AddValidations(this IServiceCollection services)
    {
        services.AddScoped<IValidator<RegisterRequest>, RegisterRequestValidator>();
        services.AddScoped<IValidator<LoginRequest>, LoginRequestValidator>();

        return services;
    }
}