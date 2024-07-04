using Authentication.ApplicationDto.Requests;
using Authentication.ApplicationDto.Respons;
using Authentication.infrastructure.DbContext;
using MediatR;

namespace Authentication.Application.Commands
{
    public class LoginCommandHandler : IRequestHandler<LoginRequestDTO, LoginResponseDTO>

    {
        private readonly AuthDbContext _context;
        private readonly IMediator _mediator;

        public LoginCommandHandler(AuthDbContext context, IMediator mediator)
        {
            _context = context;
            _mediator = mediator;
        }

        public async Task<LoginResponseDTO> Handle(LoginRequestDTO loginRequestDTO, CancellationToken cancellationToken)
        {
            var user = _context.AuthUsers.FirstOrDefault(x => x.UserName == loginRequestDTO.UserName
            && x.Password == loginRequestDTO.Password);

            //if (user == null)
                // throw AppException

            var tokenrequest = new TokenRequest();

            string jwt = await _mediator.Send(tokenrequest);


            LoginResponseDTO loginResponseDTO = new()
            {
                Token = jwt,
                User = user,
            };
            return loginResponseDTO;
        }
    }
}
