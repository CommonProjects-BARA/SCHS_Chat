using Authentication.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.ApplicationDto.Requests
{
    public class TokenRequest : IRequest<string>
    {
        public AuthUser User { get; set; }
    }
}
