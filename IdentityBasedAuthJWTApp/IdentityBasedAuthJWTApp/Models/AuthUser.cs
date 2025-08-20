using Microsoft.AspNetCore.Identity;
namespace IdentityBasedAuthApp.Models
{
    public class AuthUser: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
