using Microsoft.EntityFrameworkCore;

namespace MyDotNetAPIProject
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithOne()
                .HasForeignKey(p => p.CategoryId);

                modelBuilder.Seed();
        }
    }
}