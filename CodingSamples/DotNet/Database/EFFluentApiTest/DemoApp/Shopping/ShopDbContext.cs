global using Microsoft.EntityFrameworkCore;

namespace Shopping;

public class ShopDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=(localdb)\\SqlXE;Initial Catalog=Shop");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>()
            .ToTable("ProductInfo")
            .Property(e => e.Id)
            .HasColumnName("ProductNo");
        modelBuilder.Entity<Order>()
            .ToTable("OrderDetail")
            .Property(e => e.Id)
            .HasColumnName("OrderNo");
        modelBuilder.Entity<Order>()
            .Property("ProductId")
            .HasColumnName("ProductNo");
    }
}
