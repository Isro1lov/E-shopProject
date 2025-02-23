using E_shop.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace E_shop.DataAccess;

public class ShopContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    
    public DbSet<Category> Categories { get; set; }

    public ShopContext()
    {
        
    }
    
}