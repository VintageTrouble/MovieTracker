using MapsterMapper;

using MediatR;

using Microsoft.AspNetCore.Mvc;

using MovieTracker.Api.Controllers.Abstract;
using MovieTracker.Application.Movie.Commands.AddMovie;
using MovieTracker.Application.Movie.Common;
using MovieTracker.Application.Movie.Querise.GetMovie;
using MovieTracker.Contracts.Authentication;
using MovieTracker.Contracts.Movie;

using System.Net;

namespace MovieTracker.Api.Controllers;

[Route("api/movie")]
public class MovieController : BaseController
{
    public MovieController(ISender mediator, IMapper mapper) 
        : base(mediator, mapper) { }

    [HttpGet]
    [ProducesResponseType(typeof(AuthenticationResponse), (int)HttpStatusCode.OK)]
    public async Task<IActionResult> GetMovie(Guid id)
    {
        var response = await HandleRequest<MovieResult, MovieResponse>(
            _mapper.Map<MovieQuery>(id));

        return StatusCode((int)HttpStatusCode.OK, response);
    }

    [HttpPost("new")]
    [ProducesResponseType(typeof(AuthenticationResponse), (int)HttpStatusCode.Created)]
    public async Task<IActionResult> AddMovie(NewMovieRequest request)
    {
        var response = await HandleRequest<MovieResult, MovieResponse>(
            _mapper.Map<NewMovieCommand>(request));

        return StatusCode((int)HttpStatusCode.Created, response);
    }
}
