namespace MovieTracker.Application.Common.Interfaces.Persistence;

public interface IMovieRepository
{
    Domain.Entities.Movie? Get(Guid id);
    void Add(Domain.Entities.Movie movie);
}
