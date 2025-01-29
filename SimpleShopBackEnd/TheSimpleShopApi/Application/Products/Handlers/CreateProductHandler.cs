using MediatR;
using TheSimpleShopApi.Application.Products.Commands;
using TheSimpleShopApi.Application.Products.DTOs;
using TheSimpleShopApi.Domain.Entities.Products;
using TheSimpleShopApi.Infrastructure.Persistance;

namespace TheSimpleShopApi.Application.Products.Handlers
{
    public class CreateProductHandler : IRequestHandler<CreateProductCommand, ProductResponseDto>
    {
        private readonly ApplicationDbContext _dbContext;

        public CreateProductHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ProductResponseDto> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product
            {
                Title = request.Title,
                Description = request.Description,
                Price = request.Price,
            };

            if (request.ImageUrl != null)
            {
                product.ImageUrl = request.ImageUrl;
            }

            //if (request.CategoryId != null)
            //{
            //    product.ProductCategory = await _dbContext.ProductCategories.FindAsync(Guid.Parse(request.CategoryId));
            //}

            //if (request.CreateSkuCommands != null)
            //{
            //    product.ProductSkus = request.CreateSkuCommands.Select(sku => new ProductSku
            //    {
            //        Price = sku.Price,
            //        Quantity = sku.Quantity
            //    }).ToList();
            //}

            _dbContext.Products.Add(product);
            await _dbContext.SaveChangesAsync();
            return new ProductResponseDto
            {
                Id = product.Id.ToString(),
                Success = true,
                Message = "Product created successfully",
                ForwardLinks = new List<string> { $"api/products/{product.Id}" }
            };
        }
    }
}
