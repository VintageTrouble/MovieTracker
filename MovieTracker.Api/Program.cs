using MovieTracker.Api;
using MovieTracker.Api.Swagger;
using MovieTracker.Application;
using MovieTracker.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services
        .AddPresentation()
        .AddApplication()
        .AddInfrastructure(builder.Configuration);
}

var app = builder.Build();
{
    app.UseExceptionHandler("/api/error");

    app.ConfigueSwagger();

    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}