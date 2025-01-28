using TheSimpleShopApi.Domain.Enums;

namespace TheSimpleShopApi.Domain.Entities
{
    public class ProductSku
    {
        public int Id { get; set; }
        public Guid ProductId { get; set; }
        public Size Size { get; set; }

    }
}