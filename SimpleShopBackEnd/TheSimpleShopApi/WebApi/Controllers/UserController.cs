using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace TheSimpleShopApi.WebApi.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //TODO: Implement the User Application Logic

        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetUserById(string id)
        //{
        //    var user = await _mediator.Send(new GetUserByIdQuery(id));
        //    if (user == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(user);
        //}

        //[HttpPost]
        //public async Task<IActionResult> CreateUser([FromBody] CreateUserCommand command)
        //{
        //    var user = await _mediator.Send(command);
        //    return CreatedAtAction(nameof(GetUserById), new { id = user.Id }, user);
        //}

        //[HttpPut("{id}/roles")]
        //public async Task<IActionResult> AddApplicationUserRole(string id, [FromBody] AddUserRoleCommand command)
        //{
        //    if (id != command.UserId)
        //    {
        //        return BadRequest("User ID in the URL does not match the User ID in the command.");
        //    }

        //    var result = await _mediator.Send(command);
        //    if (!result)
        //    {
        //        return NotFound();
        //    }

        //    return NoContent();
        //}
    }
}
