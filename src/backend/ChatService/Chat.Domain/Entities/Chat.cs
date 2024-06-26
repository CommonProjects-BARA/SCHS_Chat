using Chat.Domain.Entities.Common;
using Common.Entities.Common;

namespace Chat.Domain.Entities
{
    public class Chat : AuditableEntity<int>
    {
        public ICollection<TextMessage> TextMessages { get; set; } = new List<TextMessage>();
        public ICollection<MediaMessage> MediaMessages { get; set; } = new List<MediaMessage>();
        public ICollection<int> PinnedMessages { get; set; } = new List<int>();
        public Chat() { }
    }
}
