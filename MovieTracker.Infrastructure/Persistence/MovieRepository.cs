using MovieTracker.Application.Common.Interfaces.Persistence;
using MovieTracker.Domain.Entities;

namespace MovieTracker.Infrastructure.Persistence;

public class MovieRepository : IMovieRepository
{
    private static readonly List<Movie> _movies = new();

    public Movie? GetMovie(Guid id) => _movies.FirstOrDefault(x => x.Id == id);
}
