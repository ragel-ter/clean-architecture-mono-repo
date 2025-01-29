using TheSimpleShopApi.Shared.Interfaces;

namespace TheSimpleShopApi.Application.Products.DTOs
{
    public class ProductResponseDto : IResponseDto
    {
        public required string Id { get; set; }
        public required bool Success { get; set; }
        public required string Message { get; set; }
        public List<string> ForwardLinks { get; set; } = new List<string>();
    }
}