using InitialTry.Application.Features.Events.Commands.LoginEvent;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InitialTry.Api.Controllers.v1
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger _logger;
        public AdminController(IMediator mediator, ILogger logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpPost("LoginUser")]
        public async Task<ActionResult> LoginUser()
        {
            string username = "admin", password = "admin";
            Console.WriteLine("inside");
            string str = "inside controller";
            var response = await _mediator.Send(new LoginEventCommand(username, password));
            return Ok(response);
        }
    }
}
