using Chat.Domain.Entities.Common;
using Common.Entities.Common;

namespace Chat.Domain.Entities
{
    public class Chat : AuditableEntity<int>
    {
        public ICollection<Message> Messages { get; set; } = new List<Message>();
        public ICollection<Message> PinnedMessages { get; set; } = new List<Message>();
        public Chat() { }
    }
}
