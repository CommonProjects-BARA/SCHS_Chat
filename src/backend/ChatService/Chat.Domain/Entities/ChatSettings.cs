using Common.Entities.Common;

namespace Chat.Domain.Entities
{
    public class ChatSettings : AuditableEntity<int>
    {
        public TimeSpan? CleaningInterval { get; set; }
        public DateTime? CleaningTime { get; set; }
        public ICollection<int> BlockedUser { get; set; } = new List<int>();
    }
}
