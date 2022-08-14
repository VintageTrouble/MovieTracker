using MediatR;

using MovieTracker.Application.Common.Exceptions.Movie;
using MovieTracker.Application.Common.Interfaces.Persistence;
using MovieTracker.Application.Movie.Common;

namespace MovieTracker.Application.Movie.Querise.GetMovie;

public class MovieQueryHandler : IRequestHandler<MovieQuery, MovieResult>
{
    private readonly IMovieRepository _movieRepository;

    public MovieQueryHandler(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }

    public async Task<MovieResult> Handle(MovieQuery request, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;

        if (_movieRepository.GetMovie(request.Id) is not Domain.Entities.Movie movie)
            throw new MovieNotFoundException($"Can't find movie with id [{request.Id}].");

        return new MovieResult(movie);
    }
}
