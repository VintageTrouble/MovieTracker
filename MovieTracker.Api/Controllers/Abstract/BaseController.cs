using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace MovieTracker.Api.Controllers.Abstract;

[ApiController]
[Produces("application/json")]
[ProducesResponseType(typeof(ProblemDetails), (int)HttpStatusCode.BadRequest)]
[ProducesResponseType(typeof(ProblemDetails), (int)HttpStatusCode.InternalServerError)]
public class BaseController : ControllerBase
{
    private readonly ISender _mediator;
    private readonly IMapper _mapper;

    public BaseController(ISender mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    protected async Task<TResponse?> HandleRequest<TRequest, TResponse>(IRequest<TRequest> action) 
        where TResponse : class
    {
        var authResult = await _mediator.Send(action);

        return authResult is not null
            ? _mapper.Map<TResponse>(authResult)
            : null;
    }
}