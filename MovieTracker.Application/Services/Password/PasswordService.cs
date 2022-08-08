using System.Text.RegularExpressions;

namespace MovieTracker.Application.Services.Password;

public class PasswordService : IPasswordService
{
    public int MinLength => PasswordServiceConstants.MinLength;
    public int MaxLength => PasswordServiceConstants.MaxLength;

    public int GetPasswordSecurity(string password)
    {
        var count = 0;

        if (password.Length < 8 || password.Length > 32)
            return 0;

        if (Regex.Match(password, ".*\\d.*").Success)
            count++;
        if (Regex.Match(password, ".*[a-z].*").Success)
            count++;
        if (Regex.Match(password, ".*[A-Z].*").Success)
            count++;
        if (Regex.Match(password, ".*[*.!@#$%^&(){}[]:\"; '<>,.?/~`_+-=|\\].*").Success)
            count++;

        return count;
    }
}
