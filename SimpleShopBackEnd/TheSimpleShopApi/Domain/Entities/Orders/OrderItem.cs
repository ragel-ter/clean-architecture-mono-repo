using TheSimpleShopApi.Domain.Entities.Products;

namespace TheSimpleShopApi.Domain.Entities.Orders
{
    public class OrderItem : AuditableEntity
    {
        public Guid Id { get; set; }
        public required Guid OrderId { get; set; }
        public required Order Order { get; set; }
        public required Guid ProductSkuId { get; set; }
        public required ProductSku ProductSku { get; set; }
        public required int Quantity { get; set; }
        public required decimal Price { get; set; }
        public decimal? DiscountPercentage { get; set; }
        public decimal? TotalPrice { get; set; }
        public bool IsDeleted { get; set; }
    }
}