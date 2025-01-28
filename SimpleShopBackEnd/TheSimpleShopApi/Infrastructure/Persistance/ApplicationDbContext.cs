using Microsoft.EntityFrameworkCore;
using TheSimpleShopApi.Domain.Entities;

namespace TheSimpleShopApi.Infrastructure.Persistance
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Product> Products => Set<Product>();
        public DbSet<ProductCategory> Categories => Set<ProductCategory>();
        public DbSet<ProductSku> ProductSkus => Set<ProductSku>();
        public DbSet<ProductReview> ProductReviews => Set<ProductReview>();
        public DbSet<Order> Orders => Set<Order>();
        public DbSet<OrderItem> OrderItems => Set<OrderItem>();
        public DbSet<ApplicationUser> ApplicationUsers => Set<ApplicationUser>();
        public DbSet<ApplicationRole> ApplicationRoles => Set<ApplicationRole>();
        public DbSet<ApplicationUserRole> ApplicationUserRoles => Set<ApplicationUserRole>();
    }
}
