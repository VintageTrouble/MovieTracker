namespace MovieTracker.Application.Services.Exceptions;

public interface IExceptionHandlerService
{
    (int statusCode, string message) HandleException(Exception? exception);
}