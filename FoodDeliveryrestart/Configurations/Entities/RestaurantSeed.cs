using System;
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
                    Name = "A&W",
                    CuisineType = "Fast Food",
                    LocationWithinMall = "1-24",
                    OperatingHours = "10am-10pm",
                    MallId = 1,
                    Rating = 4.4m,
                    BusyLevel = BusyLevel.Medium,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "Seed",
                    UpdatedBy = "Seed"
                },
                new Restaurant
                {
                    Id = 2,
                    Name = "Burger Lab",
                    CuisineType = "Western",
                    LocationWithinMall = "1-68",
                    OperatingHours = "10am-10pm",
                    MallId = 1,
                    Rating = 4.6m,
                    BusyLevel = BusyLevel.High,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "Seed",
                    UpdatedBy = "Seed"
                },
                new Restaurant
                {
                    Id = 3,
                    Name = "Jollibee",
                    CuisineType = "Fast Food",
                    LocationWithinMall = "8-90",
                    OperatingHours = "10am-10pm",
                    MallId = 1,
                    Rating = 4.7m,
                    BusyLevel = BusyLevel.Medium,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "Seed",
                    UpdatedBy = "Seed"
                },
                new Restaurant
                {
                    Id = 4,
                    Name = "KFC",
                    CuisineType = "Fast Food",
                    LocationWithinMall = "8-89",
                    OperatingHours = "24/7",
                    MallId = 1,
                    Rating = 4.2m,
                    BusyLevel = BusyLevel.High,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "Seed",
                    UpdatedBy = "Seed"
                },
                new Restaurant
                {
                    Id = 5,
                    Name = "McDonald's",
                    CuisineType = "Fast Food",
                    LocationWithinMall = "8-88",
                    OperatingHours = "24/7",
                    MallId = 1,
                    Rating = 4.3m,
                    BusyLevel = BusyLevel.High,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "Seed",
                    UpdatedBy = "Seed"
                },
                new Restaurant
                {
                    Id = 6,
                    Name = "Pasta Corner",
                    CuisineType = "Western",
                    LocationWithinMall = "1-67",
                    OperatingHours = "24/7",
                    MallId = 1,
                    Rating = 4.1m,
                    BusyLevel = BusyLevel.Low,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "Seed",
                    UpdatedBy = "Seed"
                },
                new Restaurant
                {
                    Id = 7,
                    Name = "Pizza House",
                    CuisineType = "Western Food",
                    LocationWithinMall = "1-66",
                    OperatingHours = "24/7",
                    MallId = 1,
                    Rating = 4.5m,
                    BusyLevel = BusyLevel.Medium,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "Seed",
                    UpdatedBy = "Seed"
                },
                new Restaurant
                {
                    Id = 8,
                    Name = "Sanook Kitchen",
                    CuisineType = "Thai Food",
                    LocationWithinMall = "1-25",
                    OperatingHours = "10am-10pm",
                    MallId = 1,
                    Rating = 4.6m,
                    BusyLevel = BusyLevel.Medium,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "Seed",
                    UpdatedBy = "Seed"
                },
                new Restaurant
                {
                    Id = 9,
                    Name = "Yochi",
                    CuisineType = "Dessert",
                    LocationWithinMall = "1-23",
                    OperatingHours = "10am-10pm",
                    MallId = 1,
                    Rating = 4.8m,
                    BusyLevel = BusyLevel.Low,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "Seed",
                    UpdatedBy = "Seed"
                }
            );
        }
    }
}
