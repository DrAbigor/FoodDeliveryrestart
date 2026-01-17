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
            var user = new FoodDeliveryrestartUser
            {
                Id = "3781efa7-66dc-47f0-860f-e506d04102e4",
                Email = "admin@localhost.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM",
                FirstName = "Admin",
                LastName = "User",
                UserName = "admin@localhost.com",
                NormalizedUserName = "ADMIN@LOCALHOST.COM",
                EmailConfirmed = true // Set to true, otherwise you won't be able to login 
            };

            var hasher = new PasswordHasher<FoodDeliveryrestartUser>();
            user.PasswordHash = hasher.HashPassword(user, "P@ssword1");

            builder.HasData(user);
        }
    }
}