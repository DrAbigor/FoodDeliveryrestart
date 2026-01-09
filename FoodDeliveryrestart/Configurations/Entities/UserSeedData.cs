using FoodDeliveryrestart.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodDeliveryrestart.Configurations.Entities
{
    public class UserSeed : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User
                {
                    Id = 1,
                    Name = "Seed User",
                    Email = "seed@food.com",
                    Password = "Password123",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "Seed",
                    UpdatedBy = "Seed"
                }
            );
        }
    }
}

