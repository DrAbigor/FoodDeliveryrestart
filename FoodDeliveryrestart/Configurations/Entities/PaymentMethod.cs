using FoodDeliveryrestart.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodDeliveryrestart.Configurations.Entities;

public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
{
    public void Configure(EntityTypeBuilder<Payment> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(p => p.CreatedBy)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(p => p.UpdatedBy)
            .IsRequired()
            .HasMaxLength(50);

        builder.HasData
        (
            new Payment
            {
                Id = 1,
                Name = "CardType",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"
            },
            new Payment
            {
                Id = 2,
                Name = "ExpiryMonth",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"
            },
            new Payment
            {
                Id = 3,
                Name = "ExpiryYear",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"
            },
            new Payment
            {
                Id = 4,
                Name = "CardHolderName",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"
            },
            new Payment
            {
                Id = 5,
                Name = "UserID",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"
            }
        );
    }
}
