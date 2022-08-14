using MediatR;

using MovieTracker.Application.Movie.Common;

namespace MovieTracker.Application.Movie.Commands.AddMovie;

public record NewMovieCommand(
    string Title,
    string Description,
    DateTime ReleaseDate) : IRequest<MovieResult>;
