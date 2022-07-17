using MovieTracker.Api.Swagger;
using MovieTracker.Application;
using MovieTracker.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services
        .AddApplication()
        .AddInfrastructure();

    builder.Services.AddControllers();
    builder.Services.AddSwagger();
}

var app = builder.Build();
{
    app.ConfigueSwagger();

    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}