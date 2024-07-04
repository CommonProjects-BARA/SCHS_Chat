using Authentication.Domain.Entities;

namespace Authentication.ApplicationDto.Respons
{
    public class LoginResponseDTO
    {
        public AuthUser User { get; set; }
        public string Token { get; set; }
    }
}
