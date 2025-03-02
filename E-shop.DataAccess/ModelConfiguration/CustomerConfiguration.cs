using e_shop.Domain.Entities.Customer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace e_shop.DataAccess.ModelConfiguration;

public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.HasKey(c=>c.Id);
        
        builder.Property(c=>c.FirstName)
            .HasColumnName("FirstName(255)")
            .IsRequired();
        
        builder.Property(c=>c.LastName)
            .HasColumnName("LastName(255)")
            .IsRequired();
        
        builder.Property(c=>c.PhoneNumber)
            .HasColumnName("PhoneNumber(50)")
            .IsRequired();
    }
}