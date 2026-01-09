using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodDeliveryrestart.Migrations
{
    /// <inheritdoc />
    public partial class AddRestaurantSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 9, 21, 50, 26, 445, DateTimeKind.Local).AddTicks(7701), new DateTime(2026, 1, 9, 21, 50, 26, 445, DateTimeKind.Local).AddTicks(7717) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 9, 21, 50, 26, 445, DateTimeKind.Local).AddTicks(7721), new DateTime(2026, 1, 9, 21, 50, 26, 445, DateTimeKind.Local).AddTicks(7722) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 9, 21, 50, 26, 445, DateTimeKind.Local).AddTicks(7724), new DateTime(2026, 1, 9, 21, 50, 26, 445, DateTimeKind.Local).AddTicks(7725) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 9, 13, 50, 26, 445, DateTimeKind.Utc).AddTicks(7213), new DateTime(2026, 1, 9, 13, 50, 26, 445, DateTimeKind.Utc).AddTicks(7220) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 9, 13, 50, 26, 445, DateTimeKind.Utc).AddTicks(7225), new DateTime(2026, 1, 9, 13, 50, 26, 445, DateTimeKind.Utc).AddTicks(7226) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 9, 13, 50, 26, 445, DateTimeKind.Utc).AddTicks(7231), new DateTime(2026, 1, 9, 13, 50, 26, 445, DateTimeKind.Utc).AddTicks(7232) });

            migrationBuilder.InsertData(
                table: "Restaurant",
                columns: new[] { "Id", "CreatedBy", "CuisineType", "DateCreated", "DateUpdated", "LocationWithinMall", "MallId", "Name", "OperatingHours", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Seed", "Western", new DateTime(2026, 1, 9, 21, 50, 26, 445, DateTimeKind.Local).AddTicks(7928), new DateTime(2026, 1, 9, 21, 50, 26, 445, DateTimeKind.Local).AddTicks(7929), "1-67", 1, "Pasta Corner", "24/7", "Seed" },
                    { 2, "Seed", "Western Food", new DateTime(2026, 1, 9, 21, 50, 26, 445, DateTimeKind.Local).AddTicks(7933), new DateTime(2026, 1, 9, 21, 50, 26, 445, DateTimeKind.Local).AddTicks(7934), "1-66", 1, "Pizza House", "24/7", "Seed" },
                    { 3, "Seed", "Western", new DateTime(2026, 1, 9, 21, 50, 26, 445, DateTimeKind.Local).AddTicks(7937), new DateTime(2026, 1, 9, 21, 50, 26, 445, DateTimeKind.Local).AddTicks(7938), "1-68", 1, "Burger Lab", "10am-10pm", "Seed" },
                    { 4, "Seed", "Fast Food", new DateTime(2026, 1, 9, 21, 50, 26, 445, DateTimeKind.Local).AddTicks(7941), new DateTime(2026, 1, 9, 21, 50, 26, 445, DateTimeKind.Local).AddTicks(7942), "8-88", 2, "McDonald's", "24/7", "Seed" },
                    { 5, "Seed", "Fast Food", new DateTime(2026, 1, 9, 21, 50, 26, 445, DateTimeKind.Local).AddTicks(7945), new DateTime(2026, 1, 9, 21, 50, 26, 445, DateTimeKind.Local).AddTicks(7946), "8-89", 2, "KFC", "24/7", "Seed" },
                    { 6, "Seed", "Fast Food", new DateTime(2026, 1, 9, 21, 50, 26, 445, DateTimeKind.Local).AddTicks(7950), new DateTime(2026, 1, 9, 21, 50, 26, 445, DateTimeKind.Local).AddTicks(7951), "8-90", 2, "Jollibee", "10am-10pm", "Seed" },
                    { 7, "Seed", "Dessert", new DateTime(2026, 1, 9, 21, 50, 26, 445, DateTimeKind.Local).AddTicks(7954), new DateTime(2026, 1, 9, 21, 50, 26, 445, DateTimeKind.Local).AddTicks(7955), "1-23", 3, "Yochi", "10am-10pm", "Seed" },
                    { 8, "Seed", "Fast Food", new DateTime(2026, 1, 9, 21, 50, 26, 445, DateTimeKind.Local).AddTicks(7958), new DateTime(2026, 1, 9, 21, 50, 26, 445, DateTimeKind.Local).AddTicks(7959), "1-24", 3, "A&W", "10am-10pm", "Seed" },
                    { 9, "Seed", "Thai Food", new DateTime(2026, 1, 9, 21, 50, 26, 445, DateTimeKind.Local).AddTicks(7962), new DateTime(2026, 1, 9, 21, 50, 26, 445, DateTimeKind.Local).AddTicks(7963), "1-25", 3, "Sanook Kitchen", "10am-10pm", "Seed" }
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 9, 21, 50, 26, 445, DateTimeKind.Local).AddTicks(8380), new DateTime(2026, 1, 9, 21, 50, 26, 445, DateTimeKind.Local).AddTicks(8382) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 9, 21, 45, 24, 559, DateTimeKind.Local).AddTicks(1823), new DateTime(2026, 1, 9, 21, 45, 24, 559, DateTimeKind.Local).AddTicks(1837) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 9, 21, 45, 24, 559, DateTimeKind.Local).AddTicks(1841), new DateTime(2026, 1, 9, 21, 45, 24, 559, DateTimeKind.Local).AddTicks(1842) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 9, 21, 45, 24, 559, DateTimeKind.Local).AddTicks(1845), new DateTime(2026, 1, 9, 21, 45, 24, 559, DateTimeKind.Local).AddTicks(1846) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 9, 13, 45, 24, 559, DateTimeKind.Utc).AddTicks(1393), new DateTime(2026, 1, 9, 13, 45, 24, 559, DateTimeKind.Utc).AddTicks(1398) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 9, 13, 45, 24, 559, DateTimeKind.Utc).AddTicks(1405), new DateTime(2026, 1, 9, 13, 45, 24, 559, DateTimeKind.Utc).AddTicks(1405) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 9, 13, 45, 24, 559, DateTimeKind.Utc).AddTicks(1410), new DateTime(2026, 1, 9, 13, 45, 24, 559, DateTimeKind.Utc).AddTicks(1411) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 9, 21, 45, 24, 559, DateTimeKind.Local).AddTicks(2445), new DateTime(2026, 1, 9, 21, 45, 24, 559, DateTimeKind.Local).AddTicks(2446) });
        }
    }
}
