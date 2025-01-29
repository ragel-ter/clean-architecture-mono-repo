using MediatR;
using TheSimpleShopApi.Application.Products.DTOs;

namespace TheSimpleShopApi.Application.Products.Commands
{
    public record CreateProductCommand(string Title, string Description, decimal Price, string? ImageUrl, string? CategoryId, List<CreateSkuCommand>? CreateSkuCommands) : IRequest<ProductResponseDto>;
}
