using System;
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

            var user = new FoodDeliveryrestartUser
            {
                Id = "c1a2b3c4-d5e6-4789-8901-234567890abc",
                Email = "admin@localhost.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM",
                FirstName = "Admin",
                LastName = "User",
                UserName = "admin@localhost.com",
                NormalizedUserName = "ADMIN@LOCALHOST.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                PhoneNumberConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString()
            };

            // Pass the actual user instance to avoid nullability warning and produce a valid password hash
            user.PasswordHash = hasher.HashPassword(user, "P@ssword1");

            builder.HasData(user);
        }
    }
}