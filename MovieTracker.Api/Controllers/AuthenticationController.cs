using MapsterMapper;

using MediatR;

using Microsoft.AspNetCore.Mvc;

using MovieTracker.Api.Controllers.Abstract;
using MovieTracker.Application.Authentication.Commands.Register;
using MovieTracker.Application.Authentication.Common;
using MovieTracker.Application.Authentication.Queries;
using MovieTracker.Contracts.Authentication;

namespace MovieTracker.Api.Controllers;

[Route("api/auth")]
public class AuthenticationController : BaseController
{
    private readonly IMapper _mapper;

    public AuthenticationController(ISender mediator, IMapper mapper)
        : base(mediator, mapper) => _mapper = mapper;

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterRequest request)
    {
        var respones = await HandleRequest<AuthenticationResult, AuthenticationResponse>(
            _mapper.Map<RegisterCommand>(request));

        return Ok(respones);
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginRequest request)
    {
        var respones = await HandleRequest<AuthenticationResult, AuthenticationResponse>(
            _mapper.Map<LoginQuery>(request));

        return Ok(respones);
    }
}

