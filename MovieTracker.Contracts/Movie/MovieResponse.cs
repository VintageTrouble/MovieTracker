namespace MovieTracker.Contracts.Movie;

public record MovieResponse(
    Guid Id,
    string Title,
    string Description,
    decimal Rate,
    DateTime ReleaseDate);
