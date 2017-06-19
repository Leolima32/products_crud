using System.Data;
using Microsoft.EntityFrameworkCore;
using products_crud.Models;
namespace products_crud.Context
{
    public class ProductsContext : DbContext
    {
        public ProductsContext(DbContextOptions<ProductsContext> options)
        : base(options) { this.Database.EnsureCreated(); }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryProducts> CategoryProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryProducts>()
            .HasKey(t => new { t.productId, t.categoryId });

            modelBuilder.Entity<CategoryProducts>()
                .HasOne(pt => pt.Product)
                .WithMany(p => p.CategoryProducts)
                .HasForeignKey(pt => pt.productId);

            modelBuilder.Entity<CategoryProducts>()
                .HasOne(pt => pt.Category)
                .WithMany(t => t.CategoryProducts)
                .HasForeignKey(pt => pt.categoryId);
        }

    }
}