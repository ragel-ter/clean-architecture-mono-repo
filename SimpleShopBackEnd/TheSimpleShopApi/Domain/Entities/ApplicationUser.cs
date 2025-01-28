namespace TheSimpleShopApi.Domain.Entities
{
    public class ApplicationUser : AuditEntity
    {
        public Guid Id { get; set; }
        public required string UserName { get; set; }
        public required string Password { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}