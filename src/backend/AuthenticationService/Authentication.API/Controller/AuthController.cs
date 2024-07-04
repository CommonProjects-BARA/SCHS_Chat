using Authentication.ApplicationDto.Requests;
using Common.API;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Authentication.API.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : CommonController
    {
        private readonly IMediator _mediator;
        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDTO loginRequestDTO)
        {
            var response = await _mediator.Send(loginRequestDTO);
            return Ok(response);
        }

        [HttpPost("Reg")]
        public async Task<IActionResult> Register([FromBody] RegistrationRequestDTO registrationRequestDTO)
        {
            var user = await _mediator.Send(registrationRequestDTO);
            if (user == null) return BadRequest("пользователь уже существует");
            return Ok(user);
        }
    }
}
