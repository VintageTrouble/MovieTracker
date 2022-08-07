using MediatR;

using MovieTracker.Application.Authentication.Common;

namespace MovieTracker.Application.Authentication.Queries.Login;

public record LoginQuery(
    string Email,
    string Password) : IRequest<AuthenticationResult>;
