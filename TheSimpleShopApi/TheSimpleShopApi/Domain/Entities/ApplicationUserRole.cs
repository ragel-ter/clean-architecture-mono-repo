namespace TheSimpleShopApi.Domain.Entities
{
    public class ApplicationUserRole : AuditEntity
    {
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }
        public bool IsActivated { get; set; }
    }
}