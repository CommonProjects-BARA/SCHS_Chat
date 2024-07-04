
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Common.ApplicarionDto
{
    internal class JWTDeserialize
    {
        public static string GetIdFromClaims(string jwt)
        {

            var tokenHandler = new JwtSecurityTokenHandler();

            var claims = tokenHandler.ReadJwtToken(jwt).Claims;

            string userId =
                claims.FirstOrDefault
                (claim => claim.Type == ClaimTypes.Name).Value;

            if (userId == string.Empty) return "ух щипиит";

            return userId;
        }
    }
}