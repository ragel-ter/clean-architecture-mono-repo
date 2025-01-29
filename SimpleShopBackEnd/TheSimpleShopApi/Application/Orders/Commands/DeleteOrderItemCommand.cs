using MediatR;
using TheSimpleShopApi.Application.Orders.DTOs;

namespace TheSimpleShopApi.Application.Orders.Commands
{
    public record DeleteOrderItemCommand(string OrderId, string OrderItemId): IRequest<OrderItemResponseDto>;
}
