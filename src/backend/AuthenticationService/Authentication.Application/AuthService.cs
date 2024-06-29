using Authentication.Domain.Entities;
using Authentication.infrastructure.DbContext;

using Microsoft.EntityFrameworkCore;

namespace AuthenticationService.Application
{
    public class AuthService
    {
        private readonly AuthDbContext _context;
        public AuthService(AuthDbContext context)
        {
            _context = context;
        }


        public async Task<string> Reg(AuthUser user) {
            var User = _context.AuthUsers.Where(x => x.UserName == user.UserName);
            if (user != null) return "AAAAAAAAAAAAAAAAAAA";

            string jwt = TokenService.GenerateToken(user);

            AuthUser authUser = new()
            {
                UserName = user.UserName,
                Email = user.Email,
                Password = user.Password,
                PhoneNumber = user.PhoneNumber,
                CreatedOn = DateTime.UtcNow,
            };

            _context.Add(authUser);
            await _context.SaveChangesAsync();

            return jwt;
        }            
        public async Task<string> Login(AuthUser user) {
            List<AuthUser> Users = await _context.AuthUsers.ToListAsync();
            AuthUser? person = 
                Users.FirstOrDefault
                (p => p.UserName == user.UserName && p.Password == user.Password);
            if (person == null) return "AAAAAAAAAAAAAAAAAAA";

            string jwt = TokenService.GenerateToken(user);
            return jwt;
        }
    }
}
