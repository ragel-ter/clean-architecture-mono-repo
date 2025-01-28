using TheSimpleShopApi.Domain.Enums;

namespace TheSimpleShopApi.Domain.Entities
{
    public class ApplicationRole : AuditEntity
    {
        public int Id { get; set; }
        public string? Label { get; set; }
        public string? Description { get; set; }
        public AppRole Role { get; set; }
    }
}