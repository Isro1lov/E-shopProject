using e_shop.Domain.Entities.Customer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace e_shop.DataAccess.ModelConfiguration;

public class CartCionfiguration : IEntityTypeConfiguration<Cart>
{
    public void Configure(EntityTypeBuilder<Cart> builder)
    {
        builder.HasKey(r => r.Id);
        
        builder.HasMany(r => r.CartItems)
            .WithOne(r => r.Cart);
    }
}