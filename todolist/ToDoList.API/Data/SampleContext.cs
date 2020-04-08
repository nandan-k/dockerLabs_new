using Microsoft.EntityFrameworkCore;
using ToDoList.API.Models;

namespace ToDoList.API.Data
{
    public class SampleContext : DbContext
    {
            public DbSet<Product> Products { get; set; }

    public SampleContext(DbContextOptions<SampleContext> options): base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.Entity<Product>().ToTable("Product");
            }
    }
}