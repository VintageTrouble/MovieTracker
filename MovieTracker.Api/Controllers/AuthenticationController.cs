using MapsterMapper;

using MediatR;

using Microsoft.AspNetCore.Mvc;

using MovieTracker.Api.Controllers.Abstract;
using MovieTracker.Application.Authentication.Commands.Register;
using MovieTracker.Application.Authentication.Common;
using MovieTracker.Application.Authentication.Queries.Login;
using MovieTracker.Contracts.Authentication;

using System.Net;

namespace MovieTracker.Api.Controllers;

[Route("api/auth")]
public class AuthenticationController : BaseController
{
    public AuthenticationController(ISender mediator, IMapper mapper)
        : base(mediator, mapper) { }

    [HttpPost("register")]
    [ProducesResponseType(typeof(AuthenticationResponse), (int)HttpStatusCode.Created)]
    [ProducesResponseType(typeof(ProblemDetails), (int)HttpStatusCode.Conflict)]
    public async Task<IActionResult> Register(RegisterRequest request)
    {
        var response = await HandleRequest<AuthenticationResult, AuthenticationResponse>(
            _mapper.Map<RegisterCommand>(request));

        return StatusCode((int)HttpStatusCode.Created, response);
    }

    [HttpPost("login")]
    [ProducesResponseType(typeof(AuthenticationResponse), (int)HttpStatusCode.OK)]
    public async Task<IActionResult> Login(LoginRequest request)
    {
        var response = await HandleRequest<AuthenticationResult, AuthenticationResponse>(
            _mapper.Map<LoginQuery>(request));

        return StatusCode((int)HttpStatusCode.OK, response);
    }
}

