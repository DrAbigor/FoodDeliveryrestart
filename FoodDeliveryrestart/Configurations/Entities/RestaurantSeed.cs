using FoodDeliveryrestart.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodDeliveryrestart.Configurations.Entities
{
    public class RestaurantSeed : IEntityTypeConfiguration<Restaurant>
    {
        public void Configure(EntityTypeBuilder<Restaurant> builder)
        {
            builder.HasData(
                new Restaurant
                {
                    Id = 1,
                    Name = "Pasta Corner",
                    CuisineType = "Western",
                    OperatingHours = "24/7",
                    LocationWithinMall = "1-67",
                    MallId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "",
                    UpdatedBy = ""
                },
                new Restaurant
                {
                    Id = 2,
                    Name = "Pizza House",
                    CuisineType = "Western Food",
                    OperatingHours = "24/7",
                    LocationWithinMall = "1-66",
                    MallId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "Seed",
                    UpdatedBy = "Seed"
                },
                new Restaurant
                {
                    Id = 3,
                    Name = "Burger Lab",
                    CuisineType = "Western",
                    OperatingHours = "10am-10pm",
                    LocationWithinMall = "1-68",
                    MallId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "Seed",
                    UpdatedBy = "Seed"
                },
                new Restaurant
                {
                    Id = 4,
                    Name = "McDonald's",
                    CuisineType = "Fast Food",
                    OperatingHours = "24/7",
                    LocationWithinMall = "8-88",
                    MallId = 2,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "Datetime.now",
                    UpdatedBy = "Seed"
                },
                new Restaurant
                {
                    Id = 5,
                    Name = "KFC",
                    CuisineType = "Fast Food",
                    OperatingHours = "24/7",
                    LocationWithinMall = "8-89",
                    MallId = 2,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "Seed",
                    UpdatedBy = "Seed"
                },
                new Restaurant
                {
                    Id = 6,
                    Name = "Jollibee",
                    CuisineType = "Fast Food",
                    OperatingHours = "10am-10pm",
                    LocationWithinMall = "8-90",
                    MallId = 2,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "Seed",
                    UpdatedBy = "Seed"
                },
                new Restaurant
                {
                    Id = 7,
                    Name = "Yochi",
                    CuisineType = "Dessert",
                    OperatingHours = "10am-10pm",
                    LocationWithinMall = "1-23",
                    MallId = 3,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "Seed",
                    UpdatedBy = "Seed"
                },
                new Restaurant
                {
                    Id = 8,
                    Name = "A&W",
                    CuisineType = "Fast Food",
                    OperatingHours = "10am-10pm",
                    LocationWithinMall = "1-24",
                    MallId = 3,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "Seed",
                    UpdatedBy = "Seed"
                },
                new Restaurant
                {
                    Id = 9,
                    Name = "Sanook Kitchen",
                    CuisineType = "Thai Food",
                    OperatingHours = "10am-10pm",
                    LocationWithinMall = "1-25",
                    MallId = 3,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "Seed",
                    UpdatedBy = "Seed"
                }
            );
        }
    }
}
