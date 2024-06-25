using Microsoft.EntityFrameworkCore;
using Common.Application.DataPersistance;

namespace Common.Infrastructure.DataPersistance
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly BaseDbContext _dbContext;

        public Repository(BaseDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<TEntity[]> GetAll(CancellationToken cancellationToken)
        {
            return await _dbContext.Set<TEntity>().ToArrayAsync(cancellationToken);
        }

        public virtual async Task<TEntity> GetById<TId>(TId id, CancellationToken cancellationToken)
        {
            return await _dbContext.Set<TEntity>().FindAsync(id, cancellationToken);
        }

        public virtual void Create(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
        }

        public virtual void Remove(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
        }
    }
}
