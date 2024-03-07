using System.ComponentModel.DataAnnotations;

namespace VerifyEmail_ForgotPassword.Models
{
    public class UserRegisterRequest
    {
        [Required , EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required, MinLength(6, ErrorMessage = "Please Enter Atleast 6 characters")]
        public string Password { get; set; } = string.Empty;
        [Required , Compare("Password")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
