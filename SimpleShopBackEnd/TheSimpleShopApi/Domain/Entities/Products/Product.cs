namespace TheSimpleShopApi.Domain.Entities.Products
{
    public class Product : AuditableEntity
    {
        public Guid Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required decimal Price { get; set; }
        public string? ImageUrl { get; set; }
        public bool? Discontinued { get; set; }
        public ProductCategory? ProductCategory { get; set; }
        public ICollection<ProductSku>? ProductSkus { get; set; }
    }
}