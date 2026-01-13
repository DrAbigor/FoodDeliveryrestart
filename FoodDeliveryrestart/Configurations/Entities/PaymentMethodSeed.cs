using FoodDeliveryrestart.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace FoodDeliveryrestart.Configurations.Entities;

public class PaymentMethodSeed : IEntityTypeConfiguration<PaymentMethod>
{
    public void Configure(EntityTypeBuilder<PaymentMethod> builder)
    {
        builder.HasKey(pm => pm.Id);

        builder.Property(pm => pm.CardType)
            .HasMaxLength(50);

        builder.Property(pm => pm.CardHolderName)
            .HasMaxLength(100);

        builder.HasData(
            new PaymentMethod
            {
                Id = 1,
                CardType = "Visa",
                ExpiryMonth = 12,
                ExpiryYear = 2026,
                CardHolderName = "Seed User",
                UserId = 1,
                DateCreated = DateTime.UtcNow,
                DateUpdated = DateTime.UtcNow,
                CreatedBy = "System",
                UpdatedBy = "System"
            },
            new PaymentMethod
            {
                Id = 2,
                CardType = "MasterCard",
                ExpiryMonth = 10,
                ExpiryYear = 2025,
                CardHolderName = "Seed User",
                UserId = 1,
                DateCreated = DateTime.UtcNow,
                DateUpdated = DateTime.UtcNow,
                CreatedBy = "System",
                UpdatedBy = "System"
            },
            new PaymentMethod
            {
                Id = 3,
                CardType = "AMEX",
                ExpiryMonth = 6,
                ExpiryYear = 2027,
                CardHolderName = "Seed User",
                UserId = 1,
                DateCreated = DateTime.UtcNow,
                DateUpdated = DateTime.UtcNow,
                CreatedBy = "System",
                UpdatedBy = "System"
            }
        );
    }
}
