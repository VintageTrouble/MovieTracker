using System.Net;

namespace MovieTracker.Application.Common.Exceptions.Abstract;

public class BaseApplicationException : Exception, IApplicationException
{
    public virtual HttpStatusCode StatusCode => HttpStatusCode.BadRequest;

    public BaseApplicationException(string? message) : base(message)
    { }
}
