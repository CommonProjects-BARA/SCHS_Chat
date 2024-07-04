using Authentication.Domain.Entities;
using MediatR;

namespace Authentication.ApplicationDto.Requests
{
    public class RegistrationRequestDTO : IRequest<AuthUser>
    {
        public  string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreatedOn { get; set; }
        
    }
}
