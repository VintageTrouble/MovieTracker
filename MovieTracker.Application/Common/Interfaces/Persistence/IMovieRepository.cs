namespace MovieTracker.Application.Common.Interfaces.Persistence;

public interface IMovieRepository
{
    Domain.Entities.Movie? GetMovie(Guid id);
}
