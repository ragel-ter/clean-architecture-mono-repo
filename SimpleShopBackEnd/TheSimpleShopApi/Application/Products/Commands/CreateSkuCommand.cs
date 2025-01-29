using MediatR;
using TheSimpleShopApi.Application.Products.DTOs;

namespace TheSimpleShopApi.Application.Products.Commands
{
    public record CreateSkuCommand() : IRequest<SkuResponseDto>;
}
