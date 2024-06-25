namespace Common.Entities.Common
{
    public interface IEntity<TEntityId>
    {
        public TEntityId Id { get; }
    }
}
