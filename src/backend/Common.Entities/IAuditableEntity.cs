namespace Common.Entities
{
    public interface IAuditableEntity
    {
        public Guid CreatedBy { get; }
        public DateTime CreatedOn { get; }
        public Guid LastModifiedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }

    }
}
