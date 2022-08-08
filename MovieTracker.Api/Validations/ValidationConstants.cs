using MovieTracker.Api.Common.Enums;

namespace MovieTracker.Api.Validations
{
    internal static class ValidationConstants
    {
        public const PasswordSecurityLevel RequiredSecurity = PasswordSecurityLevel.High;

        public const int NameMinLength = 3;
        public const int NameMaxLength = 50;
    }
}
