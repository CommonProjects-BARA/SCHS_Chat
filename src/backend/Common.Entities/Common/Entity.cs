namespace Common.Entities.Common
{
    public abstract class Entity<TEntityId> : IEntity<TEntityId>
    {
        public TEntityId Id { get; protected set; }
    }
}
