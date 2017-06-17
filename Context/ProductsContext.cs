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

    }
}