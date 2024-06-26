using AuthenticationService.Application;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SCHS.User.Domain.Entities;
using System;

namespace AuthenticationService.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        //[HttpGet("Reg")]
        //public async Task<IActionResult> Registration(AuthUser user)
        //{
        //    AuthService authService;
        //    return authService.Reg(user);
        //}
    }
}
