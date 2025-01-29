namespace TheSimpleShopApi.Domain.Entities.Users
{
    public class ApplicationUser : AuditableEntity
    {
        public Guid Id { get; set; }
        public required string UserName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}