using MediatR;
using Microsoft.AspNetCore.Mvc;
using TheSimpleShopApi.Application.Products.Commands;
using TheSimpleShopApi.Application.Products.Queries;

namespace TheSimpleShopApi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(string id)
        {
            var product = await _mediator.Send(new GetProductByIdQuery(id));
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        

        [HttpGet("{id}/skus")]
        public async Task<IActionResult> GetSkuListByProductId(string id)
        {
            var skus = await _mediator.Send(new GetSkuListByProductIdQuery(id));
            if (skus == null || !skus.Any())
            {
                return NotFound();
            }
            return Ok(skus);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] CreateProductCommand command)
        {
            var product = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetProductById), new { id = product.Id }, product);
        }

        [HttpPost("{id}/skus")]
        public async Task<IActionResult> CreateSku(string id, [FromBody] CreateSkuCommand command)
        {
            if (id != command.ProductId)
            {
                return BadRequest("Product ID in the URL does not match the Product ID in the command.");
            }

            var result = await _mediator.Send(command);
            if (result == null)
            {
                return BadRequest("Failed to create SKU.");
            }

            return CreatedAtAction(nameof(GetSkuListByProductId), new { id = command.ProductId }, result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(string id, [FromBody] UpdateProductCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest("Product ID in the URL does not match the Product ID in the command.");
            }
            var result = await _mediator.Send(command);
            if (!result)
            {
                return NotFound();
            }
            return NoContent();
        }

        [HttpPut("{id}/skus/{skuId}")]
        public async Task<IActionResult> UpdateSku(string id, string skuId, [FromBody] UpdateSkuCommand command)
        {
            if (id != command.ProductId || skuId != command.Id)
            {
                return BadRequest("Product ID or SKU ID in the URL does not match the Product ID or SKU ID in the command.");
            }
            var result = await _mediator.Send(command);
            if (!result)
            {
                return NotFound();
            }
            return NoContent();
        }
        [HttpGet]
        public async Task<IActionResult> GetAllProducts([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10)
        {
            var products = await _mediator.Send(new GetAllProductsQuery(pageNumber, pageSize));
            if (products == null || !products.Any())
            {
                return NotFound();
            }
            return Ok(products);
        }
    }
}
