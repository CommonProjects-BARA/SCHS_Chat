using Common.Entities;
using SCHS.User.Domain.Enums;

namespace SCHS.User.Domain.Entities
{
    public class User : Entity<Guid>
    {
        public DateTime CreatedOn { get; set; }
        public ActivityStatus ActivityStatus { get; set; }
        public DateTime LastActivityOn { get; set; }
        public string[] ProfileImgUrls { get; set; }
    }
}
