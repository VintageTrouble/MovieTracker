namespace MovieTracker.Application.Services.Password
{
    public interface IPasswordService
    {
        public int MinLength { get; }
        public int MaxLength { get; }
        int GetPasswordSecurity(string password);
    }
}