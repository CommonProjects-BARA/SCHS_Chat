namespace Common.Application.DataPersistance
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity[]> GetAll(CancellationToken cancellationToken);
        Task<TEntity> GetById<TId>(TId id, CancellationToken cancellationToken);
        void Create(TEntity entity);
        void Remove(TEntity entity);
    }

}
