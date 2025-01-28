namespace TheSimpleShopApi.Domain.Entities
{
    public class ProductReview : AuditEntity
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Guid UserId { get; set; }
        public string? Review { get; set; }
        public int Rating { get; set; }
    }
}
