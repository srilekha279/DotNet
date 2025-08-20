using System.ComponentModel.DataAnnotations;

namespace BasicAuthWebApi.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Full name is required.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "FullName should be between 3 and 100 characters")]
        public string FullName { get; set; } = null;

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; } = null;

        [Required(ErrorMessage = "Password hash is required")]
        public string PasswordHash { get; set; } = null;

        [Required(ErrorMessage = "Role is required.")]
        [StringLength(50, ErrorMessage = "Role cannot exceed 50 characters.")]
        public string Role { get; set; } = null;

    }
}
