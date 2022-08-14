using MovieTracker.Application.Common.Interfaces.Persistence;
using MovieTracker.Domain.Entities;

namespace MovieTracker.Infrastructure.Persistence;

public class MovieRepository : IMovieRepository
{
    private static readonly List<Movie> _movies = new();

    public void Add(Movie movie) => _movies.Add(movie);
    public Movie? Get(Guid id) => _movies.FirstOrDefault(x => x.Id == id);
}
