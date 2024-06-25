namespace Common.Entities
{
    public interface IEntity<TEntityId>
    {
        public TEntityId Id { get; }
    }
}
