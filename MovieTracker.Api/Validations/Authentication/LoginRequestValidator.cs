using FluentValidation;

using MovieTracker.Application.Services.Password;
using MovieTracker.Contracts.Authentication;

namespace MovieTracker.Api.Validations.Authentication;

public class LoginRequestValidator : AbstractValidator<LoginRequest>
{
    private readonly IPasswordService _passwordService;

    public LoginRequestValidator(IPasswordService passwordService)
    {
        _passwordService = passwordService;

        SetRules();
    }

    private void SetRules()
    {
        RuleFor(x => x.Email)
            .NotEmpty()
            .EmailAddress(FluentValidation.Validators.EmailValidationMode.AspNetCoreCompatible);

        RuleFor(x => x.Password)
            .NotEmpty()
            .Length(_passwordService.MinLength, _passwordService.MaxLength);
    }
}
