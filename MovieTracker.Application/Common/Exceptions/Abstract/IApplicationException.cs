using System.Net;

namespace MovieTracker.Application.Common.Exceptions.Abstract;

public interface IApplicationException
{
    public HttpStatusCode StatusCode { get; }
    public string Message { get; }
}