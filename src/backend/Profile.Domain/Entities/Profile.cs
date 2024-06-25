using Common.Entities.Common;
using Profile.Domain.Enums;

namespace Profile.Domain.Entities
{
    public class Profile : Entity<Guid>
    {
        public ProfileActivity ActivityStatus { get; set; }
        public ICollection<string> ImageUrls { get; set; } = new List<string>();
        public int UserId { get; set; }
    }
}
