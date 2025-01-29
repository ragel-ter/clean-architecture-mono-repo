using MediatR;
using TheSimpleShopApi.Application.Products.Commands;
using TheSimpleShopApi.Application.Products.DTOs;
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
                Name = request.Name,
                Description = request.Description,
                Skus = request.Skus.Select(sku => new Sku
                {
                    Price = sku.Price,
                    Quantity = sku.Quantity
                }).ToList()
            };
            _dbContext.Products.Add(product);
            await _dbContext.SaveChangesAsync();
            return new ProductResponseDto
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Skus = product.Skus.Select(sku => new SkuResponseDto
                {
                    Id = sku.Id,
                    Price = sku.Price,
                    Quantity = sku.Quantity
                }).ToList()
            };
        }
    }
}
