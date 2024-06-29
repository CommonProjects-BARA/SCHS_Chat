using Common.Entities.Common;

namespace Authentication.Domain.Entities
{
    public class AuthUser : Entity<Guid>
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
