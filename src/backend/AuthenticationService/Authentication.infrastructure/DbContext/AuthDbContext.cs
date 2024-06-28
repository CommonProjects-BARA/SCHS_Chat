
using Authentication.Domain.Entities;
using Common.Infrastructure.DataPersistance;
using Microsoft.EntityFrameworkCore;

namespace Authentication.infrastructure.DbContext
{
    public class AuthDbContext : BaseDbContext
    {
        public DbSet<AuthUser> AuthUsers => Set<AuthUser>();
        public AuthDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}