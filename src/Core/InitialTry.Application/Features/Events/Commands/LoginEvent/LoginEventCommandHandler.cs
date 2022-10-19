using InitialTry.Application.Contracts.Infrastructure;
using InitialTry.Application.Contracts.Persistence;
using InitialTry.Application.Responses;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTry.Application.Features.Events.Commands.LoginEvent
{
    public class LoginEventCommandHandler:IRequestHandler<LoginEventCommand, bool>
    {
        private readonly ILoginRepository _loginRepository;
        private readonly IEmailService _emailService;
        private readonly ILogger<LoginEventCommandHandler> _logger;
        private readonly IMessageRepository _messageRepository;
        public LoginEventCommandHandler(ILoginRepository loginRepository, IEmailService emailService, ILogger<LoginEventCommandHandler> logger, IMessageRepository messageRepository)
        {
            _loginRepository = loginRepository;
            _emailService = emailService;
            _logger = logger;
            _messageRepository = messageRepository;
        }

        public  async Task<bool> Handle(LoginEventCommand request, CancellationToken cancellationToken)
        {
            var loginresponse=  await Task.FromResult(_loginRepository.LoginUser(request.username, request.password));
            return loginresponse;
        }
    }
}
