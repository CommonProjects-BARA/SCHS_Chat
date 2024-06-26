using Chat.Domain.Entities.Common;

namespace Chat.Domain.Entities
{
    public class TextMessage : Message
    {
        public required string Content { get; set; }
    }
}
