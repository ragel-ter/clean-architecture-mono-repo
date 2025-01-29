namespace TheSimpleShopApi.Domain.Entities.Products
{
    public class ProductCategory
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
    }
}