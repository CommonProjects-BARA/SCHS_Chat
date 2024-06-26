using Common.Entities.Common;

namespace Chat.Domain.Entities
{
    public class ProfileChatSettings : Entity<int>
    {
        public int ChatId { get; set; }
        public virtual Chat Chat { get; set; }
        public int ProfileId { get; set; }
        public bool TurnNotice { get; set; }
        public string LayoutUrl { get; set; } = string.Empty;
        public string ChatColor { get; set; } = string.Empty;
    }
}
