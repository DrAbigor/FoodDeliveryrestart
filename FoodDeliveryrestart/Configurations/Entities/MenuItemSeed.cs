using System;
using FoodDeliveryrestart.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodDeliveryrestart.Configurations.Entities
{
    public class MenuItemSeed : IEntityTypeConfiguration<MenuItem>
    {
        public void Configure(EntityTypeBuilder<MenuItem> builder)
        {
            builder.HasData(

                // ======================
                // RestaurantId = 1 (A&W)
                // ======================
                new MenuItem { Id = 1, ItemName = "Mozza Burger", Price = 9.40m, Description = "Signature burger topped with mozzarella and onions.", Calories = 650, CarbohydratesG = 45, ProteinG = 30, FatG = 40, Allergens = "Milk, Wheat", IsHalal = true, IsVegan = false, IsNutFree = true, IsDairyFree = false, RestaurantId = 1, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "Seed", UpdatedBy = "Seed" },
                new MenuItem { Id = 2, ItemName = "Coney Dog", Price = 6.60m, Description = "Hot dog topped with savory coney sauce.", Calories = 420, CarbohydratesG = 30, ProteinG = 15, FatG = 25, Allergens = "Wheat", IsHalal = true, IsVegan = false, IsNutFree = true, IsDairyFree = true, RestaurantId = 1, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "Seed", UpdatedBy = "Seed" },
                new MenuItem { Id = 3, ItemName = "Curly Fries", Price = 3.60m, Description = "Crispy curly fries, perfect for sharing.", Calories = 360, CarbohydratesG = 48, ProteinG = 4, FatG = 16, Allergens = "", IsHalal = true, IsVegan = true, IsNutFree = true, IsDairyFree = true, RestaurantId = 1, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "Seed", UpdatedBy = "Seed" },
                new MenuItem { Id = 4, ItemName = "Root Beer Float", Price = 3.50m, Description = "Classic root beer with vanilla ice cream.", Calories = 380, CarbohydratesG = 52, ProteinG = 6, FatG = 12, Allergens = "Milk", IsHalal = true, IsVegan = false, IsNutFree = true, IsDairyFree = false, RestaurantId = 1, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "Seed", UpdatedBy = "Seed" },

                // ==========================
                // RestaurantId = 2 (Burger Lab)
                // ==========================
                new MenuItem { Id = 5, ItemName = "Basic Burger", Price = 20.50m, Description = "Juicy beef patty with house sauce and fresh veg.", Calories = 750, CarbohydratesG = 50, ProteinG = 40, FatG = 45, Allergens = "Wheat, Egg", IsHalal = true, IsVegan = false, IsNutFree = true, IsDairyFree = true, RestaurantId = 2, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "Seed", UpdatedBy = "Seed" },
                new MenuItem { Id = 6, ItemName = "Fish Burger", Price = 17.80m, Description = "Crispy fish fillet with tartar sauce.", Calories = 620, CarbohydratesG = 48, ProteinG = 30, FatG = 30, Allergens = "Fish, Wheat, Egg", IsHalal = true, IsVegan = false, IsNutFree = true, IsDairyFree = true, RestaurantId = 2, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "Seed", UpdatedBy = "Seed" },
                new MenuItem { Id = 7, ItemName = "Onion Rings", Price = 6.80m, Description = "Golden battered onion rings.", Calories = 410, CarbohydratesG = 46, ProteinG = 4, FatG = 20, Allergens = "Wheat", IsHalal = true, IsVegan = true, IsNutFree = true, IsDairyFree = true, RestaurantId = 2, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "Seed", UpdatedBy = "Seed" },
                new MenuItem { Id = 8, ItemName = "Truffle Fries", Price = 8.00m, Description = "Fries tossed with truffle oil and seasoning.", Calories = 520, CarbohydratesG = 55, ProteinG = 6, FatG = 28, Allergens = "", IsHalal = true, IsVegan = true, IsNutFree = true, IsDairyFree = true, RestaurantId = 2, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "Seed", UpdatedBy = "Seed" },

                // ==========================
                // RestaurantId = 3 (Jollibee)
                // ==========================
                new MenuItem { Id = 9, ItemName = "Chickenjoy (1pc)", Price = 5.70m, Description = "Crispy fried chicken with gravy.", Calories = 480, CarbohydratesG = 10, ProteinG = 28, FatG = 30, Allergens = "Wheat", IsHalal = true, IsVegan = false, IsNutFree = true, IsDairyFree = true, RestaurantId = 3, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "Seed", UpdatedBy = "Seed" },
                new MenuItem { Id = 10, ItemName = "Jolly Spaghetti", Price = 6.50m, Description = "Sweet-style spaghetti with hotdog slices.", Calories = 560, CarbohydratesG = 80, ProteinG = 18, FatG = 16, Allergens = "Wheat", IsHalal = true, IsVegan = false, IsNutFree = true, IsDairyFree = true, RestaurantId = 3, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "Seed", UpdatedBy = "Seed" },
                new MenuItem { Id = 11, ItemName = "Yumburger", Price = 3.90m, Description = "Classic burger with Jollibee signature dressing.", Calories = 390, CarbohydratesG = 35, ProteinG = 18, FatG = 20, Allergens = "Wheat, Egg", IsHalal = true, IsVegan = false, IsNutFree = true, IsDairyFree = true, RestaurantId = 3, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "Seed", UpdatedBy = "Seed" },
                new MenuItem { Id = 12, ItemName = "Peach Mango Pie", Price = 1.90m, Description = "Crispy pie filled with peach-mango goodness.", Calories = 260, CarbohydratesG = 34, ProteinG = 2, FatG = 12, Allergens = "Wheat", IsHalal = true, IsVegan = true, IsNutFree = true, IsDairyFree = true, RestaurantId = 3, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "Seed", UpdatedBy = "Seed" },

                // ======================
                // RestaurantId = 4 (KFC)
                // ======================
                new MenuItem { Id = 13, ItemName = "Original Recipe Chicken (1pc)", Price = 4.45m, Description = "KFC signature chicken with 11 herbs & spices.", Calories = 320, CarbohydratesG = 5, ProteinG = 24, FatG = 22, Allergens = "Wheat", IsHalal = true, IsVegan = false, IsNutFree = true, IsDairyFree = true, RestaurantId = 4, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "Seed", UpdatedBy = "Seed" },
                new MenuItem { Id = 14, ItemName = "Zinger Burger", Price = 7.50m, Description = "Spicy chicken fillet burger with mayo.", Calories = 550, CarbohydratesG = 40, ProteinG = 28, FatG = 30, Allergens = "Wheat, Egg, Milk", IsHalal = true, IsVegan = false, IsNutFree = true, IsDairyFree = false, RestaurantId = 4, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "Seed", UpdatedBy = "Seed" },
                new MenuItem { Id = 15, ItemName = "Cheese Fries", Price = 4.50m, Description = "Fries topped with warm cheese sauce.", Calories = 460, CarbohydratesG = 50, ProteinG = 8, FatG = 22, Allergens = "Milk", IsHalal = true, IsVegan = false, IsNutFree = true, IsDairyFree = false, RestaurantId = 4, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "Seed", UpdatedBy = "Seed" },
                new MenuItem { Id = 16, ItemName = "Popcorn Chicken", Price = 5.50m, Description = "Bite-sized chicken chunks, crispy and juicy.", Calories = 430, CarbohydratesG = 18, ProteinG = 26, FatG = 28, Allergens = "Wheat", IsHalal = true, IsVegan = false, IsNutFree = true, IsDairyFree = true, RestaurantId = 4, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "Seed", UpdatedBy = "Seed" },

                // =========================
                // RestaurantId = 5 (McDonald's)
                // =========================
                new MenuItem { Id = 17, ItemName = "Big Mac", Price = 7.60m, Description = "Two beef patties with special sauce and lettuce.", Calories = 540, CarbohydratesG = 47, ProteinG = 25, FatG = 29, Allergens = "Wheat, Egg, Milk", IsHalal = true, IsVegan = false, IsNutFree = true, IsDairyFree = false, RestaurantId = 5, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "Seed", UpdatedBy = "Seed" },
                new MenuItem { Id = 18, ItemName = "McSpicy", Price = 7.50m, Description = "Spicy chicken burger with lettuce and mayo.", Calories = 560, CarbohydratesG = 44, ProteinG = 30, FatG = 28, Allergens = "Wheat, Egg", IsHalal = true, IsVegan = false, IsNutFree = true, IsDairyFree = true, RestaurantId = 5, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "Seed", UpdatedBy = "Seed" },
                new MenuItem { Id = 19, ItemName = "Filet-O-Fish", Price = 7.45m, Description = "Fish patty with tartar sauce and cheese.", Calories = 390, CarbohydratesG = 38, ProteinG = 14, FatG = 18, Allergens = "Fish, Wheat, Milk", IsHalal = true, IsVegan = false, IsNutFree = true, IsDairyFree = false, RestaurantId = 5, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "Seed", UpdatedBy = "Seed" },
                new MenuItem { Id = 20, ItemName = "Apple Pie", Price = 2.50m, Description = "Crispy pastry filled with warm apple cinnamon.", Calories = 240, CarbohydratesG = 34, ProteinG = 2, FatG = 10, Allergens = "Wheat", IsHalal = true, IsVegan = true, IsNutFree = true, IsDairyFree = true, RestaurantId = 5, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "Seed", UpdatedBy = "Seed" },

                // ==========================
                // RestaurantId = 6 (Pasta Corner)
                // ==========================
                new MenuItem { Id = 21, ItemName = "Carbonara", Price = 14.90m, Description = "Creamy pasta with bacon and parmesan.", Calories = 720, CarbohydratesG = 75, ProteinG = 28, FatG = 36, Allergens = "Wheat, Milk, Egg", IsHalal = true, IsVegan = false, IsNutFree = true, IsDairyFree = false, RestaurantId = 6, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "Seed", UpdatedBy = "Seed" },
                new MenuItem { Id = 22, ItemName = "Aglio Olio", Price = 12.90m, Description = "Garlic, olive oil, chili flakes, and parsley.", Calories = 620, CarbohydratesG = 70, ProteinG = 14, FatG = 28, Allergens = "Wheat", IsHalal = true, IsVegan = true, IsNutFree = true, IsDairyFree = true, RestaurantId = 6, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "Seed", UpdatedBy = "Seed" },
                new MenuItem { Id = 23, ItemName = "Beef Bolognese", Price = 16.90m, Description = "Slow-cooked beef ragu with pasta.", Calories = 740, CarbohydratesG = 78, ProteinG = 32, FatG = 34, Allergens = "Wheat", IsHalal = true, IsVegan = false, IsNutFree = true, IsDairyFree = true, RestaurantId = 6, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "Seed", UpdatedBy = "Seed" },
                new MenuItem { Id = 24, ItemName = "Lasagna", Price = 18.90m, Description = "Layered pasta baked with meat sauce and cheese.", Calories = 850, CarbohydratesG = 80, ProteinG = 36, FatG = 46, Allergens = "Wheat, Milk", IsHalal = true, IsVegan = false, IsNutFree = true, IsDairyFree = false, RestaurantId = 6, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "Seed", UpdatedBy = "Seed" },

                // ======================
                // RestaurantId = 7 (Pizza House)
                // ======================
                new MenuItem { Id = 25, ItemName = "Margherita Pizza", Price = 12.90m, Description = "Tomato sauce, mozzarella, basil.", Calories = 780, CarbohydratesG = 90, ProteinG = 28, FatG = 32, Allergens = "Wheat, Milk", IsHalal = true, IsVegan = false, IsNutFree = true, IsDairyFree = false, RestaurantId = 7, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "Seed", UpdatedBy = "Seed" },
                new MenuItem { Id = 26, ItemName = "Pepperoni Pizza", Price = 14.90m, Description = "Pepperoni, mozzarella, tomato base.", Calories = 920, CarbohydratesG = 95, ProteinG = 36, FatG = 48, Allergens = "Wheat, Milk", IsHalal = true, IsVegan = false, IsNutFree = true, IsDairyFree = false, RestaurantId = 7, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "Seed", UpdatedBy = "Seed" },
                new MenuItem { Id = 27, ItemName = "Hawaiian Pizza", Price = 14.50m, Description = "Ham and pineapple with mozzarella.", Calories = 880, CarbohydratesG = 92, ProteinG = 34, FatG = 44, Allergens = "Wheat, Milk", IsHalal = true, IsVegan = false, IsNutFree = true, IsDairyFree = false, RestaurantId = 7, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "Seed", UpdatedBy = "Seed" },
                new MenuItem { Id = 28, ItemName = "Garlic Bread", Price = 5.50m, Description = "Toasted garlic bread slices.", Calories = 420, CarbohydratesG = 48, ProteinG = 8, FatG = 18, Allergens = "Wheat, Milk", IsHalal = true, IsVegan = false, IsNutFree = true, IsDairyFree = false, RestaurantId = 7, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "Seed", UpdatedBy = "Seed" },

                // ==========================
                // RestaurantId = 8 (Sanook Kitchen)
                // ==========================
                new MenuItem { Id = 29, ItemName = "Pineapple Fried Rice (Prawn)", Price = 9.48m, Description = "Thai-style fried rice with prawn and pineapple.", Calories = 680, CarbohydratesG = 85, ProteinG = 18, FatG = 20, Allergens = "Shellfish", IsHalal = true, IsVegan = false, IsNutFree = false, IsDairyFree = true, RestaurantId = 8, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "Seed", UpdatedBy = "Seed" },
                new MenuItem { Id = 30, ItemName = "Creamy Tom Yum Soup (Seafood)", Price = 12.90m, Description = "Creamy tom yum with seafood and herbs.", Calories = 420, CarbohydratesG = 18, ProteinG = 20, FatG = 22, Allergens = "Shellfish, Fish", IsHalal = true, IsVegan = false, IsNutFree = false, IsDairyFree = true, RestaurantId = 8, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "Seed", UpdatedBy = "Seed" },
                new MenuItem { Id = 31, ItemName = "Pad Thai (Prawn)", Price = 10.90m, Description = "Stir-fried Thai noodles with prawn.", Calories = 700, CarbohydratesG = 88, ProteinG = 20, FatG = 24, Allergens = "Shellfish, Peanuts", IsHalal = true, IsVegan = false, IsNutFree = false, IsDairyFree = true, RestaurantId = 8, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "Seed", UpdatedBy = "Seed" },
                new MenuItem { Id = 32, ItemName = "Thai Basil Chicken Rice", Price = 9.40m, Description = "Basil chicken served with fragrant rice.", Calories = 640, CarbohydratesG = 80, ProteinG = 22, FatG = 18, Allergens = "", IsHalal = true, IsVegan = false, IsNutFree = true, IsDairyFree = true, RestaurantId = 8, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "Seed", UpdatedBy = "Seed" },

                // ======================
                // RestaurantId = 9 (Yochi)
                // ======================
                new MenuItem { Id = 33, ItemName = "Signature Tart Frozen Yogurt Cup", Price = 7.90m, Description = "Classic tart froyo cup (choose toppings).", Calories = 280, CarbohydratesG = 40, ProteinG = 4, FatG = 8, Allergens = "Milk", IsHalal = true, IsVegan = false, IsNutFree = true, IsDairyFree = false, RestaurantId = 9, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "Seed", UpdatedBy = "Seed" },
                new MenuItem { Id = 34, ItemName = "Cookies & Cream Frozen Yogurt Cup", Price = 8.50m, Description = "Creamy froyo with cookies flavour.", Calories = 320, CarbohydratesG = 44, ProteinG = 5, FatG = 10, Allergens = "Milk, Wheat", IsHalal = true, IsVegan = false, IsNutFree = true, IsDairyFree = false, RestaurantId = 9, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "Seed", UpdatedBy = "Seed" },
                new MenuItem { Id = 35, ItemName = "Biscoff Spread Topping", Price = 1.50m, Description = "Add Biscoff spread as topping.", Calories = 90, CarbohydratesG = 10, ProteinG = 0, FatG = 5, Allergens = "Soy", IsHalal = true, IsVegan = true, IsNutFree = true, IsDairyFree = true, RestaurantId = 9, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "Seed", UpdatedBy = "Seed" },
                new MenuItem { Id = 36, ItemName = "Chocolate Fudge Brownie Topping", Price = 1.80m, Description = "Add chocolate brownie as topping.", Calories = 140, CarbohydratesG = 18, ProteinG = 2, FatG = 7, Allergens = "Wheat, Milk, Egg", IsHalal = true, IsVegan = false, IsNutFree = true, IsDairyFree = false, RestaurantId = 9, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "Seed", UpdatedBy = "Seed" }
            );
        }
    }
}
