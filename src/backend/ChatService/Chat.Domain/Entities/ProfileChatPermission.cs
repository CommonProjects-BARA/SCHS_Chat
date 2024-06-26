using Chat.Domain.Enums;
using Common.Entities.Common;

namespace Chat.Domain.Entities
{
    public class UserChatPermission : Entity<int>
    {
        public int ChatId { get; set; }
        public virtual Chat Chat { get; set; }
        public int ProfileId { get; set; }
        public ChatPermissions UserPermissions { get; set; }
    }
}
