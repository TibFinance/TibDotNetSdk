using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Tib.Api.Form
{

  public class PasswordValidationAttribute : ValidationAttribute
  {
    public int MinLength { get; set; } = 8;
    public int MaxLength { get; set; } = 150;
    public bool RequireUppercase { get; set; } = true;
    public bool RequireLowercase { get; set; } = true;
    public bool RequireDigit { get; set; } = true;
    public bool RequireSpecialChar { get; set; } = true;
    public string SpecialCharacters { get; set; } = @"!@#$%^&*";

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
      var password = value as string;

      if (string.IsNullOrEmpty(password))
      {
        return new ValidationResult("Password is required.");
      }

      // Check minimum length
      if (password.Length < MinLength)
      {
        return new ValidationResult($"Password must be at least {MinLength} characters long.");
      }

      if (password.Length > MaxLength)
      {
        return new ValidationResult($"Password must be no more than {MaxLength} characters long.");
      }

      // Check for uppercase letter
      if (RequireUppercase && !password.Any(char.IsUpper))
      {
        return new ValidationResult("Password must contain at least one uppercase letter.");
      }

      // Check for lowercase letter
      if (RequireLowercase && !password.Any(char.IsLower))
      {
        return new ValidationResult("Password must contain at least one lowercase letter.");
      }

      // Check for digit
      if (RequireDigit && !password.Any(char.IsDigit))
      {
        return new ValidationResult("Password must contain at least one digit.");
      }

      // Check for special character
      if (RequireSpecialChar && !password.Any(c => SpecialCharacters.Contains(c)))
      {
        return new ValidationResult($"Password must contain at least one special character ({SpecialCharacters}).");
      }

      return ValidationResult.Success;
    }

  }
}
