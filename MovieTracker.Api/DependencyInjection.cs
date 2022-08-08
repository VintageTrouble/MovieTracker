using Microsoft.AspNetCore.Mvc.Infrastructure;
using MovieTracker.Api.Common.Errors;
using MovieTracker.Api.Common.Mapping;
using MovieTracker.Api.Swagger;
using MovieTracker.Api.Validations;

namespace MovieTracker.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddSwagger();
        services.AddMappings();
        services.AddValidations();

        services.AddSingleton<ProblemDetailsFactory, MovieTrackerProblemDetailsFactory>();

        return services;
    }
}
