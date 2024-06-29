using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Common.API
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class CommonController : ControllerBase
    {
        private ISender _mediator;
        protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<ISender>();
    }
}
