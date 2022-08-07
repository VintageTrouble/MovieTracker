using MediatR;

using Microsoft.AspNetCore.Mvc;

namespace MovieTracker.Api.Controllers.Abstract;

[ApiController]
public class BaseController : ControllerBase
{
    private readonly ISender _mediator;

    public BaseController(ISender mediator)
    {
        _mediator = mediator;
    }

    protected async Task<TResponse> HandleRequest<TRequest, TResponse>(
        IRequest<TRequest> action, 
        Func<TRequest, TResponse> hadler)
    {
        var authResult = await _mediator.Send(action);
        var response = hadler(authResult);

        return response;
    }
}