using Microsoft.AspNetCore.Mvc;

using MovieTracker.Api.Controllers.Abstract;
using MovieTracker.Contracts.Authentication;

namespace MovieTracker.Api.Controllers;

[Route("api/auth")]
public class AuthenticationController : BaseController
{
    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request)
    {
        return Ok(request);
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        return Ok(request);
    }
}

