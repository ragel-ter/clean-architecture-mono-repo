﻿using MediatR;
using TheSimpleShopApi.Application.Products.DTOs;

namespace TheSimpleShopApi.Application.Products.Queries
{
    public record GetllAllProductsQuery(int pageNumber, int batchSize) : IRequest<List<ProductResponseDto>>;
}
