using TheSimpleShopApi.Domain.Entities.Users;
using TheSimpleShopApi.Domain.Enums;

namespace TheSimpleShopApi.Domain.Entities.Orders
{
    public class Order : AuditableEntity
    {
        public int Id { get; set; }
        public Guid ApplicationUserId { get; set; }
        public required ApplicationUser ApplicationUser { get; set; }
        public required OrderStatus Status { get; set; }
        public required ICollection<OrderItem> OrderItems { get; set; }
        public decimal? OrderItemTotalPriceRollup { get; set; }
        public decimal? DiscountPercentage { get; set; }
        public decimal? TotalPrice { get; set; }
    }
}