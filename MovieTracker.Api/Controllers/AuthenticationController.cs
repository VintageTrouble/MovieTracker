using MediatR;

using Microsoft.AspNetCore.Mvc;

using MovieTracker.Api.Controllers.Abstract;
using MovieTracker.Application.Authentication.Commands.Register;
using MovieTracker.Application.Authentication.Queries;
using MovieTracker.Contracts.Authentication;

namespace MovieTracker.Api.Controllers;

[Route("api/auth")]
public class AuthenticationController : BaseController
{
    public AuthenticationController(ISender mediator) : base(mediator)
    { }

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterRequest request)
    {
        var action = new RegisterCommand(
            request.FirstName,
            request.LastName,
            request.Email,
            request.Password);

        var respones = await HandleRequest(
            action,
            (authResult) => new AuthenticationResponse(
                authResult.User.Id,
                authResult.User.FirstName,
                authResult.User.LastName,
                authResult.User.Email,
                authResult.Token));

        return Ok(respones);
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginRequest request)
    {
        var action = new LoginQuery(
            request.Email,
            request.Password);

        var respones = await HandleRequest(
            action, 
            (authResult) => new AuthenticationResponse(
                authResult.User.Id,
                authResult.User.FirstName,
                authResult.User.LastName,
                authResult.User.Email,
                authResult.Token));

        return Ok(respones);
    }
}

