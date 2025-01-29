﻿using MediatR;
using TheSimpleShopApi.Application.Orders.DTOs;

namespace TheSimpleShopApi.Application.Orders.Commands
{
    public record UpdateOrderItemCommand(): IRequest<OrderItemResponseDto>;
}
