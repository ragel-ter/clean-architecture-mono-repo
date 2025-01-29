﻿using TheSimpleShopApi.Domain.Entities;

namespace TheSimpleShopApi.Shared.Interfaces
{
    public interface ICurrentUserService
    {
        string UserId { get; }
        bool IsAdmin { get; }
    }
}
