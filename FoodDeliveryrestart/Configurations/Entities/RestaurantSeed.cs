using FoodDeliveryrestart.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodDeliveryrestart.Configurations.Entities
{
    public class RestaurantSeed : IEntityTypeConfiguration<Restaurant>
    {
        public void Configure(EntityTypeBuilder<Restaurant> builder)
        {
            new Restaurant
            {
                    Id = 1,
                    Name = "Pasta Corner",
                    CuisineType = "Western",
                    OperatingHours = "24/7",
                    LocationWithinMall = "1-67",
                    MallId = 1

            };
            new Restaurant
            {
                Id = 1,
                Name = "Pizza House",
                CuisineType = "Western Food",
                OperatingHours = "24/7",
                LocationWithinMall = "1-66",
                MallId = 1
            };
            new Restaurant
            {
                Id = 1,
                Name = "Burger Lab",
                CuisineType = "Western",
                OperatingHours = "10am-10pm",
                LocationWithinMall = "1-68",
                MallId = 1
            };
            new Restaurant
            {
                Id = 2,
                Name = "macdonald",
                CuisineType = "Fast Food",
                OperatingHours = "24/7",
                LocationWithinMall = "8-88",
                MallId = 2
            };
            new Restaurant
            {
                Id = 2,
                Name = "KFC",
                CuisineType = "Fast Food",
                OperatingHours = "24/7",
                LocationWithinMall = "8-89",
                MallId = 2
            };
            new Restaurant
            {
                Id = 2,
                Name = "Jolibee",
                CuisineType = "Fast Food",
                OperatingHours = "10am-10pm",
                LocationWithinMall = "8-90",
                MallId = 2
            };
            new Restaurant
            {
                Id = 3,
                Name = "Yochi",
                CuisineType = "Dessert",
                OperatingHours = "10am-10pm",
                LocationWithinMall = "1-23",
                MallId = 3  
            };
            new Restaurant
            {
                Id = 3,
                Name = "A&W",
                CuisineType = "FastFood",
                OperatingHours = "10am-10pm",
                LocationWithinMall = "1-24",
                MallId = 3  
             };
            new Restaurant
            {
                Id = 3,
                Name = "Sanook Kitchen",
                CuisineType = "Thai Food",
                OperatingHours = "10am-10pm",
                LocationWithinMall = "1-25",
                MallId = 3  
            };
        }
    }
}