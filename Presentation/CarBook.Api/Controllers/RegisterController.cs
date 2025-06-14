using CarBook.Application.Features.Mediator.Commands.RegisterCommands;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RegisterController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateAppUserCommand createAppUserCommand)
        {
            await _mediator.Send(createAppUserCommand);
            return Ok("Kullanıcı Başarıyla Oluşturuldu");
        }
    }
}
