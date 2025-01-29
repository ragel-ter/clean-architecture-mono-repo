using MediatR;
using TheSimpleShopApi.Application.Products.DTOs;

namespace TheSimpleShopApi.Application.Products.Queries
{
    public record GetSkuListByProductIdQuery() : IRequest<List<SkuResponseDto>>;
}
