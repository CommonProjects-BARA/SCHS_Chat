using Common.Infrastructure.DataPersistance;
using Microsoft.EntityFrameworkCore;
using Profile.Domain.Entities;

namespace Profile.Infrastructure.DataPersistance
{
    public class ProfileDbContext : BaseDbContext
    {
        public DbSet<UserProfile> Profiles => Set<UserProfile>();
        public ProfileDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
