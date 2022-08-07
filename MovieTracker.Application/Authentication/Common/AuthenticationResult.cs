using MovieTracker.Domain.Entities;

namespace MovieTracker.Application.Authentication.Common;

public record AuthenticationResult(
    User User,
    string Token);

