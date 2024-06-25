using Common.Infrastructure.DataPersistance;
using Microsoft.EntityFrameworkCore;

namespace SCHS.User.Infrastructure.DataPersistance
{
    public class UserDbContext : BaseDbContext
    {
        public UserDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
