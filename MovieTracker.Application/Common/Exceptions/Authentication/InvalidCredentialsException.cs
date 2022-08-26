using MovieTracker.Application.Common.Exceptions.Abstract;

namespace MovieTracker.Application.Common.Exceptions.Authentication
{
    public class InvalidCredentialsException : BaseApplicationException
    {
        public InvalidCredentialsException() 
            : base("Login or password is incorrect.") { }
    }
}
