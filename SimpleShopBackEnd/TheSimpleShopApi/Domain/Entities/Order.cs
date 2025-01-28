using TheSimpleShopApi.Domain.Enums;

namespace TheSimpleShopApi.Domain.Entities
{
    public class Order : AuditEntity
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public OrderStatus Status { get; set; }
        public decimal OrderItemTotalPriceRollup { get; set; }
        public decimal DiscountPercentage { get; set; }
        public decimal TotalPrice { get; set; }
    }
}