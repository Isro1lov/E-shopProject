using e_shop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace e_shop.DataAccess.ModelConfiguration;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasKey(r => r.Id);
             
        builder.Property(r => r.CategoryName)
            .HasMaxLength(255)
            .IsRequired();
             
        builder.Property(r => r.Active)
            .HasDefaultValue(true);

        builder.Property(r => r.CreatedAt);

        builder.HasMany(r => r.Products)
            .WithMany(r => r.Categories);
    }
}