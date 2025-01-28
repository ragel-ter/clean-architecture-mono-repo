namespace TheSimpleShopApi.Domain.Entities
{
    public class ProductCategory : AuditEntity
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
    }
}