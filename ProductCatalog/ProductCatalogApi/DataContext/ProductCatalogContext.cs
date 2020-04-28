

using Microsoft.EntityFrameworkCore;
using ProductCatalogApi.Models;

namespace ProductCatalogApi.Data
{
    public class ProductCatalogContext : DbContext
    {
            public DbSet<Product> Products { get; set; }

    public ProductCatalogContext(DbContextOptions<ProductCatalogContext> options): base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.Entity<Product>().ToTable("Product");
            }
    }
}