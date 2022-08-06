global using Microsoft.EntityFrameworkCore;

namespace ServerApp.Shopping;

public class ShopDbContext : DbContext
{
    public DbSet<Counter> Counters { get; set; }

    public DbSet<Order> Orders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=(localdb)\\SqlXE;Initial Catalog=Shop");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>()
            .ToTable("OrderDetail")
            .Property(p => p.Id)
            .HasColumnName("OrderNo");
    }

}