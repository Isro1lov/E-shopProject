using e_shop.Domain.Entities.Tag;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace e_shop.DataAccess.ModelConfiguration;

public class TagConfiguration : IEntityTypeConfiguration<Tag>
{
    public void Configure(EntityTypeBuilder<Tag> builder)
    {
        builder.HasKey(t => t.Id);

        builder.Property(t => t.TagName)
            .HasMaxLength(255)
            .HasColumnName("tag_name")
            .HasColumnType("text")
            .IsRequired();

        builder.Property(t => t.Icon)
            .HasMaxLength(255)
            .HasColumnName("icon")
            .HasColumnType("text")
            .IsRequired();
            
        builder.Property(t => t.CreatedAt);

        builder.HasMany(t => t.ProductTags)
            .WithOne(t => t.Tag);

    }
}