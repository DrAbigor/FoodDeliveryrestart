using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodDeliveryrestart.Migrations
{
    /// <inheritdoc />
    public partial class SeedMenuItemImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1a2b3c4-d5e6-4789-8901-234567890abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0af52a1-b090-46bb-904c-26cd0045344c", "AQAAAAIAAYagAAAAEIzn6gEjT/fLg5el+q9ZZGLStGLZo0UEiSMGpXb2cpXpxBt0xouBmh9mMIJg1sFAOQ==", "ed059fd5-a991-40bd-8d13-24125241a3a0" });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 49, 42, 109, DateTimeKind.Local).AddTicks(3277), new DateTime(2026, 1, 16, 16, 49, 42, 109, DateTimeKind.Local).AddTicks(3286) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 49, 42, 109, DateTimeKind.Local).AddTicks(3287), new DateTime(2026, 1, 16, 16, 49, 42, 109, DateTimeKind.Local).AddTicks(3288) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 49, 42, 109, DateTimeKind.Local).AddTicks(3289), new DateTime(2026, 1, 16, 16, 49, 42, 109, DateTimeKind.Local).AddTicks(3290) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://source.unsplash.com/featured/600x600/?burger,cheese&sig=1" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://source.unsplash.com/featured/600x600/?hotdog&sig=2" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://source.unsplash.com/featured/600x600/?fries&sig=3" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://source.unsplash.com/featured/600x600/?root-beer,float,ice-cream&sig=4" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://source.unsplash.com/featured/600x600/?beef-burger&sig=5" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://source.unsplash.com/featured/600x600/?fish-sandwich&sig=6" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://source.unsplash.com/featured/600x600/?onion-rings&sig=7" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://source.unsplash.com/featured/600x600/?truffle,fries&sig=8" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://source.unsplash.com/featured/600x600/?fried-chicken&sig=9" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://source.unsplash.com/featured/600x600/?spaghetti&sig=10" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://source.unsplash.com/featured/600x600/?burger&sig=11" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://source.unsplash.com/featured/600x600/?mango,pie&sig=12" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://source.unsplash.com/featured/600x600/?fried-chicken,crispy&sig=13" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://source.unsplash.com/featured/600x600/?chicken-burger,spicy&sig=14" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://source.unsplash.com/featured/600x600/?cheese-fries&sig=15" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://source.unsplash.com/featured/600x600/?popcorn-chicken&sig=16" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://source.unsplash.com/featured/600x600/?burger,fast-food&sig=17" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://source.unsplash.com/featured/600x600/?spicy,chicken-burger&sig=18" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://source.unsplash.com/featured/600x600/?fish-burger&sig=19" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://source.unsplash.com/featured/600x600/?apple-pie&sig=20" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://source.unsplash.com/featured/600x600/?carbonara,pasta&sig=21" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://source.unsplash.com/featured/600x600/?aglio-olio,pasta&sig=22" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://source.unsplash.com/featured/600x600/?bolognese,pasta&sig=23" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://source.unsplash.com/featured/600x600/?lasagna&sig=24" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://source.unsplash.com/featured/600x600/?margherita,pizza&sig=25" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://source.unsplash.com/featured/600x600/?pepperoni,pizza&sig=26" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://source.unsplash.com/featured/600x600/?hawaiian,pizza&sig=27" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://source.unsplash.com/featured/600x600/?garlic-bread&sig=28" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://source.unsplash.com/featured/600x600/?pineapple,fried-rice&sig=29", true });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl", "IsDairyFree", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://source.unsplash.com/featured/600x600/?tom-yum,soup&sig=30", false, true });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://source.unsplash.com/featured/600x600/?pad-thai&sig=31" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://source.unsplash.com/featured/600x600/?thai,basil,chicken,rice&sig=32" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://source.unsplash.com/featured/600x600/?frozen-yogurt&sig=33" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://source.unsplash.com/featured/600x600/?cookies,cream,dessert&sig=34" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://source.unsplash.com/featured/600x600/?biscoff,cookie-butter&sig=35" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://source.unsplash.com/featured/600x600/?brownie,chocolate&sig=36" });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 8, 49, 42, 109, DateTimeKind.Utc).AddTicks(3153), new DateTime(2026, 1, 16, 8, 49, 42, 109, DateTimeKind.Utc).AddTicks(3153) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 8, 49, 42, 109, DateTimeKind.Utc).AddTicks(3155), new DateTime(2026, 1, 16, 8, 49, 42, 109, DateTimeKind.Utc).AddTicks(3156) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 8, 49, 42, 109, DateTimeKind.Utc).AddTicks(3157), new DateTime(2026, 1, 16, 8, 49, 42, 109, DateTimeKind.Utc).AddTicks(3158) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 49, 42, 109, DateTimeKind.Local).AddTicks(3392), new DateTime(2026, 1, 16, 16, 49, 42, 109, DateTimeKind.Local).AddTicks(3393) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 49, 42, 109, DateTimeKind.Local).AddTicks(3395), new DateTime(2026, 1, 16, 16, 49, 42, 109, DateTimeKind.Local).AddTicks(3396) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 49, 42, 109, DateTimeKind.Local).AddTicks(3398), new DateTime(2026, 1, 16, 16, 49, 42, 109, DateTimeKind.Local).AddTicks(3399) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 49, 42, 109, DateTimeKind.Local).AddTicks(3401), new DateTime(2026, 1, 16, 16, 49, 42, 109, DateTimeKind.Local).AddTicks(3401) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 49, 42, 109, DateTimeKind.Local).AddTicks(3403), new DateTime(2026, 1, 16, 16, 49, 42, 109, DateTimeKind.Local).AddTicks(3404) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 49, 42, 109, DateTimeKind.Local).AddTicks(3406), new DateTime(2026, 1, 16, 16, 49, 42, 109, DateTimeKind.Local).AddTicks(3407) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 49, 42, 109, DateTimeKind.Local).AddTicks(3409), new DateTime(2026, 1, 16, 16, 49, 42, 109, DateTimeKind.Local).AddTicks(3409) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 49, 42, 109, DateTimeKind.Local).AddTicks(3411), new DateTime(2026, 1, 16, 16, 49, 42, 109, DateTimeKind.Local).AddTicks(3412) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 49, 42, 109, DateTimeKind.Local).AddTicks(3414), new DateTime(2026, 1, 16, 16, 49, 42, 109, DateTimeKind.Local).AddTicks(3415) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 8, 49, 42, 109, DateTimeKind.Utc).AddTicks(2098), new DateTime(2026, 1, 16, 8, 49, 42, 109, DateTimeKind.Utc).AddTicks(2103) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1a2b3c4-d5e6-4789-8901-234567890abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b998c721-2fbd-4dba-87eb-c5549ffa5b2c", "AQAAAAIAAYagAAAAEBZBon5nBtoCISroIbm2lsUkl63xcRv5z6hQsYBGMZHWdNri54i6bs5EPtLrvB8yBw==", "e19dc363-572c-4fa7-a6c8-6ae1e634bdb9" });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9136), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9146) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9147), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9148) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9149), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9150) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9412), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9413), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9415), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9416), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9418), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9419), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9421), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9422), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9425), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9425), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9428), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9428), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9431), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9431), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9434), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9435), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9437), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9438), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9440), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9441), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9444), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9444), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9447), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9447), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9450), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9450), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9453), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9454), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9456), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9457), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9459), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9460), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9462), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9463), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9465), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9466), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9469), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9469), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9472), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9472), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9475), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9475), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9478), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9479), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9481), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9482), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9484), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9485), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9488), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9489), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9493), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9494), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9497), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9498), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9501), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9501), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9504), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9504), null, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl", "IsDairyFree", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9507), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9507), null, true, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9510), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9511), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9513), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9514), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9516), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9517), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9520), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9520), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9523), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9523), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9526), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9526), null });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 8, 42, 26, 589, DateTimeKind.Utc).AddTicks(8876), new DateTime(2026, 1, 16, 8, 42, 26, 589, DateTimeKind.Utc).AddTicks(8877) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 8, 42, 26, 589, DateTimeKind.Utc).AddTicks(8878), new DateTime(2026, 1, 16, 8, 42, 26, 589, DateTimeKind.Utc).AddTicks(8879) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 8, 42, 26, 589, DateTimeKind.Utc).AddTicks(8880), new DateTime(2026, 1, 16, 8, 42, 26, 589, DateTimeKind.Utc).AddTicks(8881) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9248), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9249) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9251), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9252) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9254), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9254) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9256), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9257) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9259), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9259) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9262), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9262) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9264), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9265) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9267), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9267) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9269), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9270) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 8, 42, 26, 589, DateTimeKind.Utc).AddTicks(7790), new DateTime(2026, 1, 16, 8, 42, 26, 589, DateTimeKind.Utc).AddTicks(7794) });
        }
    }
}
