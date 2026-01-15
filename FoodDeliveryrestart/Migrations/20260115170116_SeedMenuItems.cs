using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodDeliveryrestart.Migrations
{
    /// <inheritdoc />
    public partial class SeedMenuItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1a2b3c4-d5e6-4789-8901-234567890abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36e0ecf4-17bf-47a5-9652-ea6de371e64c", "AQAAAAIAAYagAAAAEFb0At0CjHXrRb/v9WoIkPefhjOSb/j5J/TuBbe+s36ESPQiMyw42u0jz/d2JO0J4Q==", "faecefda-7a90-440a-a4c1-8f41ddeecf88" });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3347), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3356) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3357), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3357) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3359), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3359) });

            migrationBuilder.InsertData(
                table: "MenuItem",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Description", "ItemName", "NutritionInfo", "Price", "RestaurantId", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Seed", new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3597), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3597), "Signature burger topped with mozzarella and onions.", "Mozza Burger", "Approx. 650 kcal", 9.40m, 1, "Seed" },
                    { 2, "Seed", new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3599), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3600), "Hot dog topped with savory coney sauce.", "Coney Dog", "Approx. 420 kcal", 6.60m, 1, "Seed" },
                    { 3, "Seed", new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3601), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3602), "Crispy curly fries, perfect for sharing.", "Curly Fries", "Approx. 360 kcal", 3.60m, 1, "Seed" },
                    { 4, "Seed", new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3604), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3604), "Classic root beer with vanilla ice cream.", "Root Beer Float", "Approx. 380 kcal", 3.50m, 1, "Seed" },
                    { 5, "Seed", new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3606), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3607), "Juicy beef patty with house sauce and fresh veg.", "Basic Burger", "Approx. 750 kcal", 20.50m, 2, "Seed" },
                    { 6, "Seed", new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3609), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3609), "Crispy fish fillet with tartar sauce.", "Fish Burger", "Approx. 620 kcal", 17.80m, 2, "Seed" },
                    { 7, "Seed", new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3611), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3611), "Golden battered onion rings.", "Onion Rings", "Approx. 410 kcal", 6.80m, 2, "Seed" },
                    { 8, "Seed", new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3613), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3614), "Fries tossed with truffle oil and seasoning.", "Truffle Fries", "Approx. 520 kcal", 8.00m, 2, "Seed" },
                    { 9, "Seed", new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3615), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3616), "Crispy fried chicken with gravy.", "Chickenjoy (1pc)", "Approx. 480 kcal", 5.70m, 3, "Seed" },
                    { 10, "Seed", new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3618), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3618), "Sweet-style spaghetti with hotdog slices.", "Jolly Spaghetti", "Approx. 560 kcal", 6.50m, 3, "Seed" },
                    { 11, "Seed", new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3620), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3621), "Classic burger with Jollibee signature dressing.", "Yumburger", "Approx. 390 kcal", 3.90m, 3, "Seed" },
                    { 12, "Seed", new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3622), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3623), "Crispy pie filled with peach-mango goodness.", "Peach Mango Pie", "Approx. 260 kcal", 1.90m, 3, "Seed" },
                    { 13, "Seed", new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3625), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3625), "KFC signature chicken with 11 herbs & spices.", "Original Recipe Chicken (1pc)", "Approx. 320 kcal", 4.45m, 4, "Seed" },
                    { 14, "Seed", new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3627), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3627), "Spicy chicken fillet burger with mayo.", "Zinger Burger", "Approx. 550 kcal", 7.50m, 4, "Seed" },
                    { 15, "Seed", new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3629), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3630), "Fries topped with warm cheese sauce.", "Cheese Fries", "Approx. 460 kcal", 4.50m, 4, "Seed" },
                    { 16, "Seed", new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3632), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3632), "Bite-sized chicken chunks, crispy and juicy.", "Popcorn Chicken", "Approx. 430 kcal", 5.50m, 4, "Seed" },
                    { 17, "Seed", new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3670), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3670), "Two beef patties with special sauce and lettuce.", "Big Mac", "Approx. 540 kcal", 7.60m, 5, "Seed" },
                    { 18, "Seed", new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3672), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3673), "Spicy chicken burger with lettuce and mayo.", "McSpicy", "Approx. 560 kcal", 7.50m, 5, "Seed" },
                    { 19, "Seed", new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3674), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3675), "Fish patty with tartar sauce and cheese.", "Filet-O-Fish", "Approx. 390 kcal", 7.45m, 5, "Seed" },
                    { 20, "Seed", new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3677), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3677), "Crispy pastry filled with warm apple cinnamon.", "Apple Pie", "Approx. 240 kcal", 2.50m, 5, "Seed" },
                    { 21, "Seed", new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3679), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3680), "Creamy pasta with bacon and parmesan.", "Carbonara", "Approx. 720 kcal", 14.90m, 6, "Seed" },
                    { 22, "Seed", new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3681), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3682), "Garlic, olive oil, chili flakes, and parsley.", "Aglio Olio", "Approx. 620 kcal", 12.90m, 6, "Seed" },
                    { 23, "Seed", new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3684), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3684), "Slow-cooked beef ragu with pasta.", "Beef Bolognese", "Approx. 740 kcal", 16.90m, 6, "Seed" },
                    { 24, "Seed", new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3686), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3687), "Layered pasta baked with meat sauce and cheese.", "Lasagna", "Approx. 850 kcal", 18.90m, 6, "Seed" },
                    { 25, "Seed", new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3688), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3689), "Tomato sauce, mozzarella, basil.", "Margherita Pizza", "Approx. 780 kcal", 12.90m, 7, "Seed" },
                    { 26, "Seed", new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3691), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3691), "Pepperoni, mozzarella, tomato base.", "Pepperoni Pizza", "Approx. 920 kcal", 14.90m, 7, "Seed" },
                    { 27, "Seed", new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3693), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3694), "Ham and pineapple with mozzarella.", "Hawaiian Pizza", "Approx. 880 kcal", 14.50m, 7, "Seed" },
                    { 28, "Seed", new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3695), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3696), "Toasted garlic bread slices.", "Garlic Bread", "Approx. 420 kcal", 5.50m, 7, "Seed" },
                    { 29, "Seed", new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3698), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3698), "Thai-style fried rice with prawn and pineapple.", "Pineapple Fried Rice (Prawn)", "Approx. 680 kcal", 9.48m, 8, "Seed" },
                    { 30, "Seed", new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3700), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3700), "Creamy tom yum with seafood and herbs.", "Creamy Tom Yum Soup (Seafood)", "Approx. 420 kcal", 12.90m, 8, "Seed" },
                    { 31, "Seed", new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3702), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3703), "Stir-fried Thai noodles with prawn.", "Pad Thai (Prawn)", "Approx. 700 kcal", 10.90m, 8, "Seed" },
                    { 32, "Seed", new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3705), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3705), "Basil chicken served with fragrant rice.", "Thai Basil Chicken Rice", "Approx. 640 kcal", 9.40m, 8, "Seed" },
                    { 33, "Seed", new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3707), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3707), "Classic tart froyo cup (choose toppings).", "Signature Tart Frozen Yogurt Cup", "Approx. 280 kcal (base)", 7.90m, 9, "Seed" },
                    { 34, "Seed", new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3709), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3710), "Creamy froyo with cookies flavour.", "Cookies & Cream Frozen Yogurt Cup", "Approx. 320 kcal (base)", 8.50m, 9, "Seed" },
                    { 35, "Seed", new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3712), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3712), "Add Biscoff spread as topping.", "Biscoff Spread Topping", "Approx. 90 kcal", 1.50m, 9, "Seed" },
                    { 36, "Seed", new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3714), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3714), "Add chocolate brownie as topping.", "Chocolate Fudge Brownie Topping", "Approx. 140 kcal", 1.80m, 9, "Seed" }
                });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 17, 1, 15, 600, DateTimeKind.Utc).AddTicks(3223), new DateTime(2026, 1, 15, 17, 1, 15, 600, DateTimeKind.Utc).AddTicks(3223) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 17, 1, 15, 600, DateTimeKind.Utc).AddTicks(3225), new DateTime(2026, 1, 15, 17, 1, 15, 600, DateTimeKind.Utc).AddTicks(3226) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 17, 1, 15, 600, DateTimeKind.Utc).AddTicks(3227), new DateTime(2026, 1, 15, 17, 1, 15, 600, DateTimeKind.Utc).AddTicks(3228) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3464), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3465) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3467), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3468) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3470), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3470) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3472), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3473) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3475), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3475) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3477), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3477) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3480), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3480) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3482), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3482) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3484), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3485) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 17, 1, 15, 600, DateTimeKind.Utc).AddTicks(2179), new DateTime(2026, 1, 15, 17, 1, 15, 600, DateTimeKind.Utc).AddTicks(2184) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1a2b3c4-d5e6-4789-8901-234567890abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b91342d3-a563-482e-94fe-dabd21d640d7", "AQAAAAIAAYagAAAAEEVbpawGOhl5qHkH4/xjBeEeSaGOROoGBFqGKgCisUt3y7MkBhoJdaPkVuaOipvC4g==", "344a7bd1-8027-44e0-8b88-2a25feb3b160" });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 0, 34, 1, 367, DateTimeKind.Local).AddTicks(9085), new DateTime(2026, 1, 16, 0, 34, 1, 367, DateTimeKind.Local).AddTicks(9093) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 0, 34, 1, 367, DateTimeKind.Local).AddTicks(9095), new DateTime(2026, 1, 16, 0, 34, 1, 367, DateTimeKind.Local).AddTicks(9095) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 0, 34, 1, 367, DateTimeKind.Local).AddTicks(9097), new DateTime(2026, 1, 16, 0, 34, 1, 367, DateTimeKind.Local).AddTicks(9097) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 16, 34, 1, 367, DateTimeKind.Utc).AddTicks(8970), new DateTime(2026, 1, 15, 16, 34, 1, 367, DateTimeKind.Utc).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 16, 34, 1, 367, DateTimeKind.Utc).AddTicks(8972), new DateTime(2026, 1, 15, 16, 34, 1, 367, DateTimeKind.Utc).AddTicks(8972) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 16, 34, 1, 367, DateTimeKind.Utc).AddTicks(8974), new DateTime(2026, 1, 15, 16, 34, 1, 367, DateTimeKind.Utc).AddTicks(8974) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 0, 34, 1, 367, DateTimeKind.Local).AddTicks(9342), new DateTime(2026, 1, 16, 0, 34, 1, 367, DateTimeKind.Local).AddTicks(9342) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 0, 34, 1, 367, DateTimeKind.Local).AddTicks(9344), new DateTime(2026, 1, 16, 0, 34, 1, 367, DateTimeKind.Local).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 0, 34, 1, 367, DateTimeKind.Local).AddTicks(9347), new DateTime(2026, 1, 16, 0, 34, 1, 367, DateTimeKind.Local).AddTicks(9347) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 0, 34, 1, 367, DateTimeKind.Local).AddTicks(9349), new DateTime(2026, 1, 16, 0, 34, 1, 367, DateTimeKind.Local).AddTicks(9350) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 0, 34, 1, 367, DateTimeKind.Local).AddTicks(9352), new DateTime(2026, 1, 16, 0, 34, 1, 367, DateTimeKind.Local).AddTicks(9352) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 0, 34, 1, 367, DateTimeKind.Local).AddTicks(9354), new DateTime(2026, 1, 16, 0, 34, 1, 367, DateTimeKind.Local).AddTicks(9355) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 0, 34, 1, 367, DateTimeKind.Local).AddTicks(9357), new DateTime(2026, 1, 16, 0, 34, 1, 367, DateTimeKind.Local).AddTicks(9357) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 0, 34, 1, 367, DateTimeKind.Local).AddTicks(9359), new DateTime(2026, 1, 16, 0, 34, 1, 367, DateTimeKind.Local).AddTicks(9359) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 0, 34, 1, 367, DateTimeKind.Local).AddTicks(9361), new DateTime(2026, 1, 16, 0, 34, 1, 367, DateTimeKind.Local).AddTicks(9362) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 16, 34, 1, 367, DateTimeKind.Utc).AddTicks(7974), new DateTime(2026, 1, 15, 16, 34, 1, 367, DateTimeKind.Utc).AddTicks(7978) });
        }
    }
}
