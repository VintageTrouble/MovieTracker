using MediatR;

using MovieTracker.Application.Authentication.Common;
using MovieTracker.Application.Common.Exceptions;
using MovieTracker.Application.Common.Exceptions.Authentication;
using MovieTracker.Application.Common.Interfaces.Authentication;
using MovieTracker.Application.Common.Interfaces.Persistence;
using MovieTracker.Domain.Entities;

namespace MovieTracker.Application.Authentication.Queries.Login;

public class LoginQueryHandler : IRequestHandler<LoginQuery, AuthenticationResult>
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepository _userRepository;

    public LoginQueryHandler(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userRepository = userRepository;
    }

    public async Task<AuthenticationResult> Handle(LoginQuery query, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;

        if (_userRepository.GetByEmail(query.Email) is not User user)
            throw new InvalidCredentialsException();

        if (query.Password != user.Password)
            throw new InvalidCredentialsException();

        var token = _jwtTokenGenerator.GenerateToken(user);

        return new AuthenticationResult(
            user,
            token);
    }
}
