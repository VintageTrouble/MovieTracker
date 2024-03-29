﻿using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

using MovieTracker.Application.Services.Exceptions;

namespace MovieTracker.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class ErrorController : ControllerBase
    {
        private readonly IExceptionHandlerService _exceptionHandler;
        public ErrorController(IExceptionHandlerService exceptionHandler)
        {
            _exceptionHandler = exceptionHandler;
        }

        public IActionResult Error()
        {
            var exception = HttpContext.Features.Get<IExceptionHandlerFeature>()?.Error;
            var (statusCode, message) = _exceptionHandler.HandleException(exception);

            return Problem(title: message, statusCode: statusCode);
        }
    }
}
