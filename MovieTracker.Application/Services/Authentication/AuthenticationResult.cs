using MovieTracker.Domain.Entities;

namespace MovieTracker.Application.Services.Authentication;

public record AuthenticationResult(
    User User,
    string Token);

