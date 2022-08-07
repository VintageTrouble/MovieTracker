using System.ComponentModel.DataAnnotations;

namespace MovieTracker.Contracts.Authentication;

public record LoginRequest(
    [Required] string Email,
    [Required] string Password);
