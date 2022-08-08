using FluentValidation;
using FluentValidation.Validators;

using MovieTracker.Application.Services.Password;
using MovieTracker.Contracts.Authentication;

namespace MovieTracker.Api.Validations.Authentication;

public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
{
    private readonly IPasswordService _passwordService;

    public RegisterRequestValidator(IPasswordService passwordService)
    {
        _passwordService = passwordService;

        SetRules();
    }

    private void SetRules()
    {
        RuleFor(x => x.FirstName)
            .NotEmpty()
            .Length(ValidationConstants.NameMinLength, ValidationConstants.NameMaxLength);

        RuleFor(x => x.LastName)
            .NotEmpty()
            .Length(ValidationConstants.NameMinLength, ValidationConstants.NameMaxLength);

        RuleFor(x => x.Email)
            .NotEmpty()
            .EmailAddress(EmailValidationMode.AspNetCoreCompatible);

        RuleFor(x => x.Password)
            .Must(PasswordValidates);
    }

    private bool PasswordValidates(string password) 
        => _passwordService.GetPasswordSecurity(password) >= (int)ValidationConstants.RequiredSecurity;
}
