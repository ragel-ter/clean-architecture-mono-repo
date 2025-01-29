using Microsoft.EntityFrameworkCore;
using TheSimpleShopApi.Domain.Entities;
using TheSimpleShopApi.Domain.Entities.Orders;
using TheSimpleShopApi.Domain.Entities.Products;
using TheSimpleShopApi.Domain.Entities.Users;
using TheSimpleShopApi.Shared.Interfaces;

namespace TheSimpleShopApi.Infrastructure.Persistance
{
    public class ApplicationDbContext : DbContext
    {
        private readonly ICurrentUserService _currentUserService;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, ICurrentUserService currentUserService) : base(options)
        {
            _currentUserService = currentUserService ?? throw new ArgumentNullException(nameof(currentUserService));
        }

        public DbSet<Product> Products => Set<Product>();
        public DbSet<ProductCategory> Categories => Set<ProductCategory>();
        public DbSet<ProductSku> ProductSkus => Set<ProductSku>();
        public DbSet<Order> Orders => Set<Order>();
        public DbSet<OrderItem> OrderItems => Set<OrderItem>();
        public DbSet<ApplicationUser> ApplicationUsers => Set<ApplicationUser>();
        public DbSet<ApplicationRole> ApplicationRoles => Set<ApplicationRole>();
        public DbSet<ApplicationUserRole> ApplicationUserRoles => Set<ApplicationUserRole>();

        public override int SaveChanges()
        {
            SetAuditProperties();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            SetAuditProperties();
            return base.SaveChangesAsync(cancellationToken);
        }

        private void SetAuditProperties()
        {
            var entries = ChangeTracker.Entries<AuditableEntity>();
                
            foreach (var entry in entries)
            {
                var now = DateTime.UtcNow;
                var userId = _currentUserService.UserId;

                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.SetAuditFieldsOnCreate(now, userId);
                        entry.Entity.SetAuditFieldsOnUpdate(now, userId);
                        break;
                    case EntityState.Modified:
                        entry.Entity.SetAuditFieldsOnUpdate(now, userId);
                        break;
                }
            }
        }   
    }
}
