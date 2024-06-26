using AuthenticationService.Domain.Entities;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using SCHS.User.Domain.Entities;
using Microsoft.IdentityModel.Tokens;


namespace AuthenticationService.Application
{
    public class TokenService
    {

        public static string GenerateToken(AuthUser user)
        {
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Jti, user.Id.ToString())
            };

            var jwt = new JwtSecurityToken(
                     issuer: AuthOptions.ISSUER,
                     audience: AuthOptions.AUDIENCE,
                     claims: claims,
                     expires: DateTime.UtcNow.Add(TimeSpan.FromMinutes(5)),
                     signingCredentials:
                     new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(),
                     SecurityAlgorithms.HmacSha256));
                
            
            return new JwtSecurityTokenHandler().WriteToken(jwt);
        }

    }
}
