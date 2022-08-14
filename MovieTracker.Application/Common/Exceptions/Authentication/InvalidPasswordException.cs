using MovieTracker.Application.Common.Exceptions.Abstract;

namespace MovieTracker.Application.Common.Exceptions;

public class InvalidPasswordException : BaseApplicationException
{
    public InvalidPasswordException(string message)
        : base(message) { }
}