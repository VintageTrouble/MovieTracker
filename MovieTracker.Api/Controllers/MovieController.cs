using MapsterMapper;

using MediatR;

using Microsoft.AspNetCore.Mvc;

using MovieTracker.Api.Controllers.Abstract;
using MovieTracker.Application.Movie.Common;
using MovieTracker.Application.Movie.Querise.GetMovie;
using MovieTracker.Contracts.Movie;

using System.Net;

namespace MovieTracker.Api.Controllers;

[Route("api/movie")]
public class MovieController : BaseController
{
    public MovieController(ISender mediator, IMapper mapper) 
        : base(mediator, mapper) { }

    [HttpGet("/[id]")]
    public async Task<IActionResult> GetMovie([FromQuery] Guid id)
    {
        var response = await HandleRequest<MovieResult, MovieResponse>(
            _mapper.Map<MovieQuery>(id));

        return StatusCode((int)HttpStatusCode.OK, response);
    }
}
