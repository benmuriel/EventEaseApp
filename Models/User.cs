using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class User
    {
        [Required(ErrorMessage = "Username is required.")]
        [StringLength(50, ErrorMessage = "Username must be under 50 characters.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }
    }
}
