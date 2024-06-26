using Common.Entities.Common;

namespace Chat.Domain.Entities.Common
{
    public abstract class Message : AuditableEntity<Guid>
    {
        public int ProfileId { get; protected set; }
    }
}
