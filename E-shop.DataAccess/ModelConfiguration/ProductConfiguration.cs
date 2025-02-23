using e_shop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace e_shop.DataAccess.ModelConfiguration;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    //private IEntityTypeConfiguration<Product> _entityTypeConfigurationImplementation;
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(r => r.Id);
             
        builder.Property(r => r.SKU)
            .HasMaxLength(255)
            .IsRequired();
             
        builder.Property(r => r.ProductName)
            .HasMaxLength(255)
            .HasColumnName("product_name")
            .HasColumnType("text")
            .IsRequired();
    
        builder.Property(r => r.RegularPrice)
            .HasDefaultValue(0)
            .IsRequired();

        builder.HasMany(r => r.Categories)
            .WithMany(r => r.Products);
    }
}