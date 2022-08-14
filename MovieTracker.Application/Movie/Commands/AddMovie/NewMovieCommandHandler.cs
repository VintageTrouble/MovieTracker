using MediatR;

using MovieTracker.Application.Common.Interfaces.Persistence;
using MovieTracker.Application.Movie.Common;

namespace MovieTracker.Application.Movie.Commands.AddMovie;

public class NewMovieCommandHandler : IRequestHandler<NewMovieCommand, MovieResult>
{
    private readonly IMovieRepository _movieRepository;

    public NewMovieCommandHandler(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }

    public async Task<MovieResult> Handle(NewMovieCommand request, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;

        var movie = new Domain.Entities.Movie
        {
            Title = request.Title,
            Description = request.Description,
            ReleaseDate = request.ReleaseDate
        };

        _movieRepository.Add(movie);

        return new MovieResult(movie);
    }
}
