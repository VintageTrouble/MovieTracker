namespace MovieTracker.Domain.Entities;

public class Movie
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public decimal Rate { get; set; }
    public DateTime ReleaseDate { get; set; }
}
