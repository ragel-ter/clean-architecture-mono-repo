using TheSimpleShopApi.Domain.Enums;

namespace TheSimpleShopApi.Domain.Entities.Users
{
    public class ApplicationRole
    {
        public Guid Id { get; set; }
        public required AppRole Role { get; set; }
        public string? Label { get; set; }
        public string? Description { get; set; }
    }
}