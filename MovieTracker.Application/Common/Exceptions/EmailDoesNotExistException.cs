using MovieTracker.Application.Common.Exceptions.Abstract;

namespace MovieTracker.Application.Common.Exceptions;

public class EmailDoesNotExistException : BaseApplicationException
{    public EmailDoesNotExistException(string message)
        : base(message) { }
}