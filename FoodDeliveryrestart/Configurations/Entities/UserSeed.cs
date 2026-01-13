using FoodDeliveryrestart.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace FoodDeliveryrestart.Configurations.Entities
{
    public class UserSeed : IEntityTypeConfiguration<FoodDeliveryrestartUser>
    {
        public void Configure(EntityTypeBuilder<FoodDeliveryrestartUser> builder)
        {
            var hasher = new PasswordHasher<FoodDeliveryrestartUser>();
            builder.HasData(
                new FoodDeliveryrestartUser
                {
                    Id = "c1a2b3c4-d5e6-4789-8901-234567890abc",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    FirstName = "Admin",
                    LastName = "User",
                    UserName = "admin@localhost.com",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true // Set to true, otherwise you won't be able to login
                });
        }
    }
}