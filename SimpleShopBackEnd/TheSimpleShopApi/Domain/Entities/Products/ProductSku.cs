using TheSimpleShopApi.Domain.Enums;

namespace TheSimpleShopApi.Domain.Entities.Products
{
    public class ProductSku : AuditableEntity
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public Guid ProductId { get; set; }
        public required Product Product { get; set; }
        public Size? Size { get; set; }
        public string? color { get; set; }
        public string? material { get; set; }
        public string? ImageUrl { get; set; }
    }
}