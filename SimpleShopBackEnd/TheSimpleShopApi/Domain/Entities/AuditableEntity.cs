using TheSimpleShopApi.Shared.Interfaces;

namespace TheSimpleShopApi.Domain.Entities
{
    public abstract class AuditableEntity : IAuditEntity
    {
        private DateTime _createdAt;
        private string? _createdByUserId;
        public DateTime CreatedAt { get => _createdAt; set => _createdAt = value; }
        public string CreatedByUserId { get => _createdByUserId ?? string.Empty; set => _createdByUserId = value; }

        public void SetAuditFieldsOnCreate(DateTime now, string userId)
        {
            CreatedAt = now;
            CreatedByUserId = userId;
        }

        private DateTime _updatedAt;
        private string? _updatedByUserId;

        public DateTime UpdatedAt { get => _updatedAt; set => _updatedAt = value; }
        public string UpdatedByUserId { get => _updatedByUserId ?? string.Empty; set => _updatedByUserId = value; }

        public void SetAuditFieldsOnUpdate(DateTime now, string userId)
        {
            UpdatedAt = now;
            UpdatedByUserId = userId;
        }
    }
}
