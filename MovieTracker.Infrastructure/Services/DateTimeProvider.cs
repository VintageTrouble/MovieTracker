using MovieTracker.Application.Common.Interfaces.Services;

namespace MovieTracker.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}

