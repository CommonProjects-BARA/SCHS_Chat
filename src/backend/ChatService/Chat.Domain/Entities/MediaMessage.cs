using Chat.Domain.Entities.Common;
using Chat.Domain.Enums;

namespace Chat.Domain.Entities
{
    public class MediaMessage : Message
    {
        public required string ContentUrl { get; set; }
        public MediaType MediaType { get; set; }
    }
}
