using MediatR;
using TheSimpleShopApi.Application.Orders.DTOs;

namespace TheSimpleShopApi.Application.Orders.Commands
{
    public record CreateOrderCommand(string ApplicationUserId, List<CreateOrderItemCommand> CreateOrderItems, decimal? DiscountPercentage) : IRequest<OrderResponseDto>;
}
