using MovieTracker.Domain.Entities;

namespace MovieTracker.Application.Common.Interfaces.Persistence;

public interface IUserRepository
{
    User? GetByEmail(string email);
    void Add(User user);
}
