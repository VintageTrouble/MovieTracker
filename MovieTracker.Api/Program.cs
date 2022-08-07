using Microsoft.AspNetCore.Mvc.Infrastructure;

using MovieTracker.Api.Common.Errors;
using MovieTracker.Api.Swagger;
using MovieTracker.Application;
using MovieTracker.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services
        .AddApplication()
        .AddInfrastructure(builder.Configuration);

    builder.Services.AddControllers();
    builder.Services.AddSwagger();

    builder.Services.AddSingleton<ProblemDetailsFactory, MovieTrackerProblemDetailsFactory>();
}

var app = builder.Build();
{
    app.UseExceptionHandler("/api/error");

    app.ConfigueSwagger();

    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}