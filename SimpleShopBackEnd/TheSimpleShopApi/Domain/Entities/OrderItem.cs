namespace TheSimpleShopApi.Domain.Entities
{
    public class OrderItem : AuditEntity
    {
        public Guid OrderId { get; set; }
        public Guid ProductSkuId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountPercentage { get; set; }
        public decimal TotalPrice { get; set; }
    }
}