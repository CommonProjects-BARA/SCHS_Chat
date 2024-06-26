using Common.Infrastructure.DataPersistance;
using Microsoft.EntityFrameworkCore;
using SCHS.User.Domain.Entities;

namespace AuthenticationService.Infrastructure.DbContext
{
    public class AuthDbContext : BaseDbContext
    {
        public DbSet<AuthUser> AuthUsers => Set<AuthUser>();
        public AuthDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
