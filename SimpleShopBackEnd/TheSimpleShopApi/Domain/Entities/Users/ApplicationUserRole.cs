namespace TheSimpleShopApi.Domain.Entities.Users
{
    public class ApplicationUserRole : AuditableEntity
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public required ApplicationUser User { get; set; }
        public Guid RoleId { get; set; }
        public required ApplicationRole Role { get; set; }
        public bool IsActivated { get; set; }
    }
}