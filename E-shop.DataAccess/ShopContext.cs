using e_shop.Domain.Entities;
using e_shop.Domain.Entities.Customer;
using e_shop.Domain.Entities.Order;
using e_shop.Domain.Entities.Tag;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace e_shop.DataAccess;

public class ShopContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Cart> Carts { get; set; }
    public DbSet<CartItem> CartItems { get; set; }
    public DbSet<CustomerAddress> CustomerAddress { get; set; }
    
    public DbSet<Order> Orders { get; set; }
    
    public DbSet<OrderItem> OrderItems { get; set; }
    
    //FluentAPI
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ShopContext).Assembly);


        // //ManyToMany
        //  modelBuilder.Entity<ProductCategory>(builder =>
        //  {
        //      builder.HasKey(r => new { r.ProductId, r.CategoryId });
        //      builder.HasOne(r => r.Category)
        //          .WithMany(r => r.ProductCategories);
        //      builder.HasOne(r => r.Product)
        //          .WithMany(r => r.ProductCategories);
        //  });

        modelBuilder.Entity<ProductTag>(builder =>
        {
            builder.HasKey(t => new { t.ProductId, t.TagId });
            builder.HasOne(t => t.Tag)
                .WithMany(t => t.ProductTags);
            builder.HasOne(t => t.Product)
                .WithMany(t => t.ProductTags);
        });

        //OneToMany
        modelBuilder.Entity<Cart>()
            .HasMany(c => c.CartItems)
            .WithOne(c => c.Cart);

        modelBuilder.Entity<CartItem>()
            .HasOne(c => c.Cart)
            .WithMany(c => c.CartItems)
            .HasForeignKey(c => c.CardId);
    }

    //Seeding


    // public ShopContext()
    // {
    //     Database.EnsureCreated();
    // }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = "Server=localhost;Port=5432;Database=eCommerce;User Id=postgres;Password=nuri8322;";
        
        optionsBuilder
            //.UseLazyLoadingProxies()
            .UseNpgsql(connectionString) 
            //.LogTo(Console.WriteLine, LogLevel.Information)
            .UseSnakeCaseNamingConvention();
            //.UseLazyLoading();

    }

    
    
    // public override int SaveChanges()
    // {
    //     var entries = ChangeTracker.Entries();
    //     var addedEntities = entries.Where(e => e.State == EntityState.Added);
    //     var updatedEntities = entries.Where(e => e.State == EntityState.Modified);
    //
    //     foreach (var entry in addedEntities)
    //     {
    //         if (entry.Entity is IAuditable entity)
    //         {
    //             entity.CreatedAt = DateTime.UtcNow;
    //             entity.CreatedBy = 1;
    //         }
    //     }
    //
    //     foreach (var entry in updatedEntities)
    //     {
    //         if (entry.Entity is IAuditable entity)
    //         {
    //             
    //         }
    //         
    //     }
    // }

}
    