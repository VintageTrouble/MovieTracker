using MovieTracker.Domain.Entities;

namespace MovieTracker.Application.Common.Interfaces.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}
