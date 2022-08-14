using MovieTracker.Application.Common.Exceptions.Abstract;

using System.Net;

namespace MovieTracker.Application.Common.Exceptions;

class DuplicateEmailException : BaseApplicationException
{
    public override HttpStatusCode StatusCode => HttpStatusCode.Conflict;

    public DuplicateEmailException(string message) 
        : base(message) { }
}
