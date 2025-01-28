namespace TheSimpleShopApi.Domain.Entities
{
    public class Product : AuditEntity
    {
        public Guid Id { get; set; }
        public Guid CategoryId { get; set; }
        public required string Title { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; }
        public bool Discontinued { get; set; }
    }
}