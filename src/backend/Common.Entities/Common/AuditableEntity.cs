namespace Common.Entities.Common
{
    public abstract class AuditableEntity<TEntityId> : Entity<TEntityId>, IAuditableEntity
    {
        public Guid CreatedBy { get; protected set; }
        public DateTime CreatedOn { get; protected set; }
        public Guid LastModifiedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
        protected AuditableEntity()
        {
            CreatedBy = default;
            CreatedOn = DateTime.UtcNow;
            LastModifiedBy = default;
            LastModifiedOn = DateTime.UtcNow;
        }

    }
}
