using MovieTracker.Application.Common.Exceptions.Abstract;

using System.Net;

namespace MovieTracker.Application.Common.Exceptions.Movie;

public class MovieNotFoundException : BaseApplicationException
{
    public override HttpStatusCode StatusCode => HttpStatusCode.NotFound;
    public MovieNotFoundException(string? message) 
        : base(message) { }
}
