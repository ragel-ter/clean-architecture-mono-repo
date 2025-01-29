namespace TheSimpleShopApi.Shared.Interfaces
{
    public interface IAuditEntity
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CreatedByUserId { get; set; }
        public string UpdatedByUserId { get; set; }
        public void SetAuditFieldsOnCreate(DateTime now, string userId);
        public void SetAuditFieldsOnUpdate(DateTime now, string userId);
    }
}
