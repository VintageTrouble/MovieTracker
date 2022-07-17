﻿using MovieTracker.Application.Common.Interfaces.Persistence;
using MovieTracker.Domain.Entities;

namespace MovieTracker.Infrastructure.Persistence;

public class UserRepository : IUserRepository
{
    private static readonly List<User> _users = new ();

    public void Add(User user)
    {
        _users.Add(user);
    }

    public User? GetByEmail(string email)
    {
        return _users.SingleOrDefault(u => u.Email == email);
    }
}
