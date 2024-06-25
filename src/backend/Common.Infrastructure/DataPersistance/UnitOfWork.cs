using Common.Application.DataPersistance;

namespace Common.Infrastructure.DataPersistance
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BaseDbContext _dbContext;

        public UnitOfWork(BaseDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CommitAsync(CancellationToken cancellationToken = default)
        {
            await _dbContext.SaveChangesAsync(cancellationToken);
        }

    }
}
