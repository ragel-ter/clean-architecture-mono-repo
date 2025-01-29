using MediatR;
using TheSimpleShopApi.Application.Products.DTOs;

namespace TheSimpleShopApi.Application.Products.Queries
{
    public record GetProductByIdQuery(string id) : IRequest<ProductResponseDto>;
}
