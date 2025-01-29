using MediatR;
using TheSimpleShopApi.Application.Products.DTOs;

namespace TheSimpleShopApi.Application.Products.Commands
{
    public record UpdateSkuCommand() : IRequest<SkuResponseDto>;
}
 