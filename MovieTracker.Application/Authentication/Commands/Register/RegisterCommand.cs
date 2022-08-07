using MediatR;

using MovieTracker.Application.Authentication.Common;

namespace MovieTracker.Application.Authentication.Commands.Register;

public record RegisterCommand(
    string FirstName,
    string LastName,
    string Email,
    string Password) : IRequest<AuthenticationResult>;
