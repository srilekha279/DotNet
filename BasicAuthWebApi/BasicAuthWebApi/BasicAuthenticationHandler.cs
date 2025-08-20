using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Options;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Xml.Schema;
using BasicAuthWebApi.Models;

namespace BasicAuthWebApi
{
    public class BasicAuthenticationHandler
        : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        UserDbContext _context = null;
        public BasicAuthenticationHandler(IOptionsMonitor<AuthenticationSchemeOptions> options, ILoggerFactory logger, UrlEncoder encoder):base(options, logger, encoder)
        {
            //_context = Context;
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            try
            {
                if (!Request.Headers.ContainsKey("Authorization"))
                    return AuthenticateResult.Fail("Missing authentication header");
                var authenticationHeader = Request.Headers["Authorization"].ToString();
                if(!AuthenticationHeaderValue.TryParse(authenticationHeader, out var headerValue))
                    return AuthenticateResult.Fail("Invalid authentication header");
                if(!"Basic".Equals(headerValue.Scheme, StringComparison.OrdinalIgnoreCase))
                    return AuthenticateResult.Fail("Invalid authentication schema");
                var credentialBytes = Convert.FromBase64String(headerValue.Parameter);
                var credentials = Encoding.UTF8.GetString(credentialBytes).Split(":", 2);
                if(credentials.Length != 2)
                {
                    return AuthenticateResult.Fail("Invalid authentication header");
                }
                var email = credentials[0];
                var password = credentials[1];
                var user = new User { Id = 1, FullName = "Lekha", Email = "srilekha.2764@gmail.com", PasswordHash = PasswordHasher.HashPassword("lekha27"), Role = "Administrator, Manager" };
                if(user == null || !PasswordHasher.VerifyPassword(user.PasswordHash, password))
                {
                    return AuthenticateResult.Fail("Invalid user name or password.");
                }
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Name,user.Email)
                };
                var roles = user.Role.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
                foreach(var role in roles )
                {
                    claims.Add(new Claim(ClaimTypes.Role, role));
                }
                var claimIdentity = new ClaimsIdentity(claims, Scheme.Name);
                var claimPrincipal = new ClaimsPrincipal(claimIdentity);

                var authenticationTicket = new AuthenticationTicket(claimPrincipal, Scheme.Name);
                return AuthenticateResult.Success(authenticationTicket);
            }
            catch (Exception ex)
            {
                return AuthenticateResult.Fail("Error occured during authentication");
            }
        }
    }
}
