﻿using Microsoft.OpenApi.Models;

namespace MovieTracker.Api.Swagger;

public static class StartupSwaggerConfiguration
{
    public static void AddSwagger(this IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();

        services.AddSwaggerGen(
            c =>
            {
                c.SwaggerDoc(
                    "v1",
                    new OpenApiInfo
                    {
                        Title = "Movie Tracker",
                        Version = "v1"
                    });
            });
    }

    public static void ConfigueSwagger(this WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.RoutePrefix = "swagger"; // serve the UI at root 	
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "V1");
            });
        }
    }
}

