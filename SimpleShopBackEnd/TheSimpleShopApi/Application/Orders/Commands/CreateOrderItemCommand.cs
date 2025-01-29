using MediatR;
using TheSimpleShopApi.Application.Orders.DTOs;

namespace TheSimpleShopApi.Application.Orders.Commands
{
    public record CreateOrderItemCommand(string OrderId, string ProductSkuId, int Quantity, decimal? DiscountPercentage) : IRequest<OrderItemResponseDto>;
}
