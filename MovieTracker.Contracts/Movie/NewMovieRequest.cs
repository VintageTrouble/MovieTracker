namespace MovieTracker.Contracts.Movie;

public record NewMovieRequest(
    string Title,
    string Description,
    DateTime ReleaseDate);
