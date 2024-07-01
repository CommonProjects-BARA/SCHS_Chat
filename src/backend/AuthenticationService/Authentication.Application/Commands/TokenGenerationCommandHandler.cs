using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Authentication.ApplicationDto.Requests;
using Authentication.Domain.Entities;
using MediatR;
using Microsoft.IdentityModel.Tokens;

namespace Authentication.Application.Handlers
{
    public class GenerateTokenCommandHandler : IRequestHandler<TokenRequest, string>
    {
        

        public async Task<string> Handle(TokenRequest request, CancellationToken cancellationToken)
        {
            var user = request.User;

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Id.ToString())
            };

            var jwt = new JwtSecurityToken(
                     issuer: AuthOptions.ISSUER,
                     audience: AuthOptions.AUDIENCE,
                     claims: claims,
                     expires: DateTime.UtcNow.AddDays(7),
                     signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));

            return await Task.FromResult(new JwtSecurityTokenHandler().WriteToken(jwt));
        }
    }
}
