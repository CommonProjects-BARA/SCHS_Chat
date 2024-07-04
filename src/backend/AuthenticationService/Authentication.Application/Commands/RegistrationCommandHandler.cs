using Authentication.ApplicationDto.Requests;
using Authentication.Domain.Entities;
using Authentication.infrastructure.DbContext;
using MediatR;


namespace Authentication.Application.Commands
{
    internal class RegistrationCommandHandler : IRequestHandler<RegistrationRequestDTO, AuthUser>
    {
        private readonly AuthDbContext _context;

        public RegistrationCommandHandler(AuthDbContext context)
        {
            _context = context;
        }
        public bool IsUniqueUser(string name)
        {
            var user = _context.AuthUsers.FirstOrDefault(x => x.UserName == name);

            if (user == null)
                return true;

            return false;
        }
        public async Task<AuthUser> Handle(RegistrationRequestDTO request, CancellationToken cancellationToken)
        {
            if (!IsUniqueUser(request.UserName)) return null;

            AuthUser user = new()
            {
                UserName = request.UserName,
                Password = request.Password,
                Email = request.Email,
                PhoneNumber = request.PhoneNumber,
                CreatedOn = request.CreatedOn,
            };

            _context.AuthUsers.Add(user);
            await _context.SaveChangesAsync(cancellationToken);

            return user;
        }
    }
}
