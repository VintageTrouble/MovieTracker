using MovieTracker.Api.Swagger;
using MovieTracker.Application;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddApplication();
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