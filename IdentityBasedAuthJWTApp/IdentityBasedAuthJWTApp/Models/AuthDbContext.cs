using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using IdentityBasedAuthApp;
namespace IdentityBasedAuthApp.Models
{
    public class AuthDbContext:IdentityDbContext<AuthUser>
    {
        public AuthDbContext(DbContextOptions<AuthDbContext>options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
