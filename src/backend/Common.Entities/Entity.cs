namespace Common.Entities
{
    public abstract class Entity<TEntityId> : IEntity<TEntityId>
    {
        public TEntityId Id { get; protected set; }
    }
}
