using ebuy.Application.UseCases.Users.Command.CreateUser;
using ebuy.WebApi.Models.Requests.Users;
using ebuy.WebApi.SeedWork;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ControllerBase = ebuy.WebApi.SeedWork.ControllerBase;

namespace ebuy.WebApi.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator) 
            : base(mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { Message = "Invalid input data" });

            var dto = new CreateUserDTO
            {
                Name = request.Name,
                Password = request.Password,
                Email = request.Email
            };

            var command = new CreateUserCommand(dto);

            var response = await _mediator.Send(command);

            return Ok(response);

        }
    }
}
