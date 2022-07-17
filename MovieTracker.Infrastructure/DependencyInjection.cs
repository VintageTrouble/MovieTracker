﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using MovieTracker.Application.Common.Interfaces.Authentication;
using MovieTracker.Application.Common.Interfaces.Services;
using MovieTracker.Infrastructure.Authentication;
using MovieTracker.Infrastructure.Services;

namespace MovieTracker.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, ConfigurationManager configuration)
    {
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));

        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();

        return services;
    }
}

