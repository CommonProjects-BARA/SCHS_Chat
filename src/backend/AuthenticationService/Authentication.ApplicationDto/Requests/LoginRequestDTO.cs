using Authentication.ApplicationDto.Respons;
using MediatR;

namespace Authentication.ApplicationDto.Requests
{
    public class LoginRequestDTO : IRequest<LoginResponseDTO>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
