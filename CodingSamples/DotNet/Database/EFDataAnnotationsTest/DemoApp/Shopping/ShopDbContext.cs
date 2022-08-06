global using Microsoft.EntityFrameworkCore;

namespace Shopping;

public class ShopDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=shop.db");
    }
}
