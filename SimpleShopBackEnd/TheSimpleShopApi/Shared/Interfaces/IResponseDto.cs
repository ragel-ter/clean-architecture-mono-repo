﻿namespace TheSimpleShopApi.Shared.Interfaces
{
    public interface IResponseDto 
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public List<string> ForwardLinks { get; set; }
    }
}
