using MediatR;

using MovieTracker.Application.Movie.Common;

namespace MovieTracker.Application.Movie.Querise.GetMovie;

public record MovieQuery(Guid Id) : IRequest<MovieResult>;
