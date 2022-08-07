using MovieTracker.Application.Common.Exceptions.Abstract;

using System.Net;

namespace MovieTracker.Application.Services.Exceptions;

public class ExceptionHandler : IExceptionHandlerService
{
    public (int statusCode, string message) HandleException(Exception? exception)
        => exception switch
        {
            IApplicationException applicationException => ((int)applicationException.StatusCode, applicationException.Message),
            _ => ((int)HttpStatusCode.InternalServerError, "Unexpected error occured.")
        };
}
