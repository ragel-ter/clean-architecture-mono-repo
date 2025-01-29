using MediatR;
using Microsoft.AspNetCore.Mvc;
using TheSimpleShopApi.Application.Orders.Commands;

namespace TheSimpleShopApi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;
        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetOrderById(string id)
        //{
        //    var order = await _mediator.Send(new GetOrderByIdQuery(id));
        //    if (order == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(order);
        //}
        
        //[HttpPost]
        //public async Task<IActionResult> CreateOrder([FromBody] CreateOrderCommand command)
        //{
        //    command.UserId = _currentUserService.UserId;
        //    var order = await _mediator.Send(command);
        //    return CreatedAtAction(nameof(GetOrderById), new { id = order.Id }, order);
        //}
        
        //[HttpPut("{id}/status")]
        //public async Task<IActionResult> UpdateOrderStatus(string id, [FromBody] UpdateOrderCommand command)
        //{
        //    if (id != command.OrderId)
        //    {
        //        return BadRequest("Order ID in the URL does not match the Order ID in the command.");
        //    }
        //    var result = await _mediator.Send(command);
        //    if (!result)
        //    {
        //        return NotFound();
        //    }
        //    return NoContent();
        //}

        //[HttpPut("{id}/items")]
        //public async Task<IActionResult> AddOrderItem(string id, [FromBody] UpdateOrderCommand command)
        //{
        //    if (id != command.OrderId)
        //    {
        //        return BadRequest("Order ID in the URL does not match the Order ID in the command.");
        //    }
        //    var result = await _mediator.Send(command);
        //    if (result == null)
        //    {
        //        return NotFound();
        //    }
        //    return CreatedAtAction(nameof(GetOrderById), new { id = result.Id }, result);
        //}

        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteOrder(string id)
        //{
        //    var result = await _mediator.Send(new DeleteOrderCommand(id));
        //    if (!result)
        //    {
        //        return NotFound();
        //    }
        //    return NoContent();
        //}
    }
}
