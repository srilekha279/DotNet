using System.ComponentModel.DataAnnotations;

namespace IdentityBasedAuthApp.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Username is required")]
        public string? UserName{get; set;}
        [Required(ErrorMessage = "password is required")]
        public string? Password { get; set;}
    }
}
