using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodDeliveryrestart.Migrations
{
    /// <inheritdoc />
    public partial class AddMenuItemDietaryFlags : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDairyFree",
                table: "MenuItem",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsHalal",
                table: "MenuItem",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsNutFree",
                table: "MenuItem",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsVegan",
                table: "MenuItem",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1a2b3c4-d5e6-4789-8901-234567890abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd4a113e-1490-4827-8c1a-80d3bdff9b6a", "AQAAAAIAAYagAAAAEGPIJdG0Yo9Ni8vu5J2OBbkJoTotzBTWFI3ISM/Fjp/tiDw0TbbiJCXqnWZpoz/ClA==", "0f87f318-a6f1-4fdb-b90e-4bb5bab77af7" });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5255), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5262) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5264), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5264) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5266), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5266) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree", "IsVegan" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5494), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5494), false, false, false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree", "IsVegan" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5496), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5497), false, false, false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree", "IsVegan" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5499), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5500), false, false, false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree", "IsVegan" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5502), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5502), false, false, false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree", "IsVegan" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5504), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5505), false, false, false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree", "IsVegan" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5507), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5507), false, false, false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree", "IsVegan" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5510), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5510), false, false, false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree", "IsVegan" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5512), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5513), false, false, false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree", "IsVegan" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5515), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5515), false, false, false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree", "IsVegan" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5517), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5518), false, false, false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree", "IsVegan" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5520), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5521), false, false, false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree", "IsVegan" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5523), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5523), false, false, false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree", "IsVegan" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5525), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5526), false, false, false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree", "IsVegan" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5528), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5529), false, false, false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree", "IsVegan" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5531), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5531), false, false, false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree", "IsVegan" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5533), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5534), false, false, false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree", "IsVegan" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5536), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5537), false, false, false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree", "IsVegan" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5539), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5539), false, false, false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree", "IsVegan" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5541), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5542), false, false, false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree", "IsVegan" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5544), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5544), false, false, false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree", "IsVegan" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5547), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5547), false, false, false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree", "IsVegan" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5549), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5550), false, false, false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree", "IsVegan" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5552), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5552), false, false, false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree", "IsVegan" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5554), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5555), false, false, false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree", "IsVegan" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5587), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5588), false, false, false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree", "IsVegan" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5590), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5591), false, false, false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree", "IsVegan" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5593), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5593), false, false, false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree", "IsVegan" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5596), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5596), false, false, false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree", "IsVegan" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5598), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5599), false, false, false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree", "IsVegan" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5601), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5601), false, false, false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree", "IsVegan" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5604), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5604), false, false, false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree", "IsVegan" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5606), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5607), false, false, false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree", "IsVegan" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5609), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5609), false, false, false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree", "IsVegan" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5611), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5612), false, false, false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree", "IsVegan" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5614), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5615), false, false, false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree", "IsVegan" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5617), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5617), false, false, false, false });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 17, 43, 4, 908, DateTimeKind.Utc).AddTicks(5136), new DateTime(2026, 1, 15, 17, 43, 4, 908, DateTimeKind.Utc).AddTicks(5137) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 17, 43, 4, 908, DateTimeKind.Utc).AddTicks(5138), new DateTime(2026, 1, 15, 17, 43, 4, 908, DateTimeKind.Utc).AddTicks(5139) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 17, 43, 4, 908, DateTimeKind.Utc).AddTicks(5141), new DateTime(2026, 1, 15, 17, 43, 4, 908, DateTimeKind.Utc).AddTicks(5141) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5363), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5363) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5365), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5366) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5368), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5368) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5370), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5371) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5373), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5373) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5375), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5376) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5378), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5378) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5380), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5381) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5383), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5383) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 17, 43, 4, 908, DateTimeKind.Utc).AddTicks(3981), new DateTime(2026, 1, 15, 17, 43, 4, 908, DateTimeKind.Utc).AddTicks(3984) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDairyFree",
                table: "MenuItem");

            migrationBuilder.DropColumn(
                name: "IsHalal",
                table: "MenuItem");

            migrationBuilder.DropColumn(
                name: "IsNutFree",
                table: "MenuItem");

            migrationBuilder.DropColumn(
                name: "IsVegan",
                table: "MenuItem");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1a2b3c4-d5e6-4789-8901-234567890abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce481bc4-0517-466a-a51e-b68d8d5b499a", "AQAAAAIAAYagAAAAEBooxpRX0ThtfBwGHuoWJ7Vfc1BNRX1Iq7oDw2Z9iNVkz7G9QhAbHRm/KhJpelPYnQ==", "0f0734e9-0947-4dd8-a315-d4c5512f4ab2" });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6678), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6685) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6686), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6687) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6688), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6689) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6971), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6971) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6974), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6974) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6976), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6977) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6979), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6980) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6982), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6982) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6984), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6985) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6987), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6988) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6990), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6990) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6993), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6993) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6995), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6996) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6998), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6998) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7001), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7001) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7003), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7004) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7006), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7006) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7009), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7009) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7011), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7012) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7014), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7015) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7017), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7017) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7019), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7020) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7022), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7023) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7025), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7025) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7027), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7028) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7030), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7031) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7033), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7033) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7036), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7036) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7041), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7042) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7048), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7048) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7054), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7054) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7063), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7063) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7069), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7069) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7075), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7075) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7081), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7081) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7086), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7087) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7089), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7089) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7091), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7092) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7094), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7095) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 17, 31, 0, 254, DateTimeKind.Utc).AddTicks(6531), new DateTime(2026, 1, 15, 17, 31, 0, 254, DateTimeKind.Utc).AddTicks(6532) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 17, 31, 0, 254, DateTimeKind.Utc).AddTicks(6533), new DateTime(2026, 1, 15, 17, 31, 0, 254, DateTimeKind.Utc).AddTicks(6534) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 17, 31, 0, 254, DateTimeKind.Utc).AddTicks(6536), new DateTime(2026, 1, 15, 17, 31, 0, 254, DateTimeKind.Utc).AddTicks(6537) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6774), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6777), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6778) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6780), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6780) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6782), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6783) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6785), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6785) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6787), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6788) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6790), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6790) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6792), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6793) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6795), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 17, 31, 0, 254, DateTimeKind.Utc).AddTicks(5991), new DateTime(2026, 1, 15, 17, 31, 0, 254, DateTimeKind.Utc).AddTicks(5993) });
        }
    }
}
