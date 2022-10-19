using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTry.Application.Features.Events.Commands.LoginEvent
{
    public record LoginEventCommand(string username,string password) : IRequest<bool>;

}
