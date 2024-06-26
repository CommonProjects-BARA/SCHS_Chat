using Common.Entities.Common;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace AuthenticationService.Domain.Entities
{
    public class AuthOptions : Entity<Guid>
    {
        public const string ISSUER = "Server";
        public const string AUDIENCE = "Cli";
        const string KEY = "32simvolov12345632simvolov123456";
        public static SymmetricSecurityKey GetSymmetricSecurityKey() =>
            new SymmetricSecurityKey(Encoding.UTF8.GetBytes(KEY));
    }
}
