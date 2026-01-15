using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodDeliveryrestart.Migrations
{
    /// <inheritdoc />
    public partial class AddMenuItemNutritionFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NutritionInfo",
                table: "MenuItem");

            migrationBuilder.AddColumn<string>(
                name: "Allergens",
                table: "MenuItem",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Calories",
                table: "MenuItem",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CarbohydratesG",
                table: "MenuItem",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FatG",
                table: "MenuItem",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProteinG",
                table: "MenuItem",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "Allergens", "Calories", "CarbohydratesG", "DateCreated", "DateUpdated", "FatG", "ProteinG" },
                values: new object[] { "Milk, Wheat", 650, 45, new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6971), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6971), 40, 30 });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Allergens", "Calories", "CarbohydratesG", "DateCreated", "DateUpdated", "FatG", "ProteinG" },
                values: new object[] { "Wheat", 420, 30, new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6974), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6974), 25, 15 });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Allergens", "Calories", "CarbohydratesG", "DateCreated", "DateUpdated", "FatG", "ProteinG" },
                values: new object[] { "", 360, 48, new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6976), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6977), 16, 4 });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Allergens", "Calories", "CarbohydratesG", "DateCreated", "DateUpdated", "FatG", "ProteinG" },
                values: new object[] { "Milk", 380, 52, new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6979), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6980), 12, 6 });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Allergens", "Calories", "CarbohydratesG", "DateCreated", "DateUpdated", "FatG", "ProteinG" },
                values: new object[] { "Wheat, Egg", 750, 50, new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6982), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6982), 45, 40 });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Allergens", "Calories", "CarbohydratesG", "DateCreated", "DateUpdated", "FatG", "ProteinG" },
                values: new object[] { "Fish, Wheat, Egg", 620, 48, new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6984), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6985), 30, 30 });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Allergens", "Calories", "CarbohydratesG", "DateCreated", "DateUpdated", "FatG", "ProteinG" },
                values: new object[] { "Wheat", 410, 46, new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6987), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6988), 20, 4 });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Allergens", "Calories", "CarbohydratesG", "DateCreated", "DateUpdated", "FatG", "ProteinG" },
                values: new object[] { "", 520, 55, new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6990), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6990), 28, 6 });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Allergens", "Calories", "CarbohydratesG", "DateCreated", "DateUpdated", "FatG", "ProteinG" },
                values: new object[] { "Wheat", 480, 10, new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6993), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6993), 30, 28 });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Allergens", "Calories", "CarbohydratesG", "DateCreated", "DateUpdated", "FatG", "ProteinG" },
                values: new object[] { "Wheat", 560, 80, new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6995), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6996), 16, 18 });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Allergens", "Calories", "CarbohydratesG", "DateCreated", "DateUpdated", "FatG", "ProteinG" },
                values: new object[] { "Wheat, Egg", 390, 35, new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6998), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(6998), 20, 18 });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Allergens", "Calories", "CarbohydratesG", "DateCreated", "DateUpdated", "FatG", "ProteinG" },
                values: new object[] { "Wheat", 260, 34, new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7001), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7001), 12, 2 });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Allergens", "Calories", "CarbohydratesG", "DateCreated", "DateUpdated", "FatG", "ProteinG" },
                values: new object[] { "Wheat", 320, 5, new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7003), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7004), 22, 24 });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Allergens", "Calories", "CarbohydratesG", "DateCreated", "DateUpdated", "FatG", "ProteinG" },
                values: new object[] { "Wheat, Egg, Milk", 550, 40, new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7006), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7006), 30, 28 });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Allergens", "Calories", "CarbohydratesG", "DateCreated", "DateUpdated", "FatG", "ProteinG" },
                values: new object[] { "Milk", 460, 50, new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7009), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7009), 22, 8 });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Allergens", "Calories", "CarbohydratesG", "DateCreated", "DateUpdated", "FatG", "ProteinG" },
                values: new object[] { "Wheat", 430, 18, new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7011), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7012), 28, 26 });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Allergens", "Calories", "CarbohydratesG", "DateCreated", "DateUpdated", "FatG", "ProteinG" },
                values: new object[] { "Wheat, Egg, Milk", 540, 47, new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7014), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7015), 29, 25 });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Allergens", "Calories", "CarbohydratesG", "DateCreated", "DateUpdated", "FatG", "ProteinG" },
                values: new object[] { "Wheat, Egg", 560, 44, new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7017), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7017), 28, 30 });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Allergens", "Calories", "CarbohydratesG", "DateCreated", "DateUpdated", "FatG", "ProteinG" },
                values: new object[] { "Fish, Wheat, Milk", 390, 38, new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7019), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7020), 18, 14 });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Allergens", "Calories", "CarbohydratesG", "DateCreated", "DateUpdated", "FatG", "ProteinG" },
                values: new object[] { "Wheat", 240, 34, new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7022), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7023), 10, 2 });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Allergens", "Calories", "CarbohydratesG", "DateCreated", "DateUpdated", "FatG", "ProteinG" },
                values: new object[] { "Wheat, Milk, Egg", 720, 75, new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7025), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7025), 36, 28 });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Allergens", "Calories", "CarbohydratesG", "DateCreated", "DateUpdated", "FatG", "ProteinG" },
                values: new object[] { "Wheat", 620, 70, new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7027), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7028), 28, 14 });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Allergens", "Calories", "CarbohydratesG", "DateCreated", "DateUpdated", "FatG", "ProteinG" },
                values: new object[] { "Wheat", 740, 78, new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7030), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7031), 34, 32 });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Allergens", "Calories", "CarbohydratesG", "DateCreated", "DateUpdated", "FatG", "ProteinG" },
                values: new object[] { "Wheat, Milk", 850, 80, new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7033), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7033), 46, 36 });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Allergens", "Calories", "CarbohydratesG", "DateCreated", "DateUpdated", "FatG", "ProteinG" },
                values: new object[] { "Wheat, Milk", 780, 90, new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7036), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7036), 32, 28 });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Allergens", "Calories", "CarbohydratesG", "DateCreated", "DateUpdated", "FatG", "ProteinG" },
                values: new object[] { "Wheat, Milk", 920, 95, new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7041), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7042), 48, 36 });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Allergens", "Calories", "CarbohydratesG", "DateCreated", "DateUpdated", "FatG", "ProteinG" },
                values: new object[] { "Wheat, Milk", 880, 92, new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7048), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7048), 44, 34 });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Allergens", "Calories", "CarbohydratesG", "DateCreated", "DateUpdated", "FatG", "ProteinG" },
                values: new object[] { "Wheat, Milk", 420, 48, new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7054), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7054), 18, 8 });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Allergens", "Calories", "CarbohydratesG", "DateCreated", "DateUpdated", "FatG", "ProteinG" },
                values: new object[] { "Shellfish", 680, 85, new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7063), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7063), 20, 18 });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Allergens", "Calories", "CarbohydratesG", "DateCreated", "DateUpdated", "FatG", "ProteinG" },
                values: new object[] { "Shellfish, Fish", 420, 18, new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7069), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7069), 22, 20 });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Allergens", "Calories", "CarbohydratesG", "DateCreated", "DateUpdated", "FatG", "ProteinG" },
                values: new object[] { "Shellfish, Peanuts", 700, 88, new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7075), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7075), 24, 20 });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Allergens", "Calories", "CarbohydratesG", "DateCreated", "DateUpdated", "FatG", "ProteinG" },
                values: new object[] { "", 640, 80, new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7081), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7081), 18, 22 });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Allergens", "Calories", "CarbohydratesG", "DateCreated", "DateUpdated", "FatG", "ProteinG" },
                values: new object[] { "Milk", 280, 40, new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7086), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7087), 8, 4 });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Allergens", "Calories", "CarbohydratesG", "DateCreated", "DateUpdated", "FatG", "ProteinG" },
                values: new object[] { "Milk, Wheat", 320, 44, new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7089), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7089), 10, 5 });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Allergens", "Calories", "CarbohydratesG", "DateCreated", "DateUpdated", "FatG", "ProteinG" },
                values: new object[] { "Soy", 90, 10, new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7091), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7092), 5, 0 });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Allergens", "Calories", "CarbohydratesG", "DateCreated", "DateUpdated", "FatG", "ProteinG" },
                values: new object[] { "Wheat, Milk, Egg", 140, 18, new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7094), new DateTime(2026, 1, 16, 1, 31, 0, 254, DateTimeKind.Local).AddTicks(7095), 7, 2 });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Allergens",
                table: "MenuItem");

            migrationBuilder.DropColumn(
                name: "Calories",
                table: "MenuItem");

            migrationBuilder.DropColumn(
                name: "CarbohydratesG",
                table: "MenuItem");

            migrationBuilder.DropColumn(
                name: "FatG",
                table: "MenuItem");

            migrationBuilder.DropColumn(
                name: "ProteinG",
                table: "MenuItem");

            migrationBuilder.AddColumn<string>(
                name: "NutritionInfo",
                table: "MenuItem",
                type: "nvarchar(max)",
                nullable: true);

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

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "NutritionInfo" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3597), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3597), "Approx. 650 kcal" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "NutritionInfo" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3599), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3600), "Approx. 420 kcal" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "NutritionInfo" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3601), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3602), "Approx. 360 kcal" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "NutritionInfo" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3604), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3604), "Approx. 380 kcal" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated", "NutritionInfo" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3606), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3607), "Approx. 750 kcal" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated", "NutritionInfo" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3609), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3609), "Approx. 620 kcal" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated", "NutritionInfo" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3611), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3611), "Approx. 410 kcal" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated", "NutritionInfo" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3613), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3614), "Approx. 520 kcal" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated", "NutritionInfo" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3615), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3616), "Approx. 480 kcal" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated", "NutritionInfo" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3618), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3618), "Approx. 560 kcal" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated", "NutritionInfo" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3620), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3621), "Approx. 390 kcal" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated", "NutritionInfo" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3622), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3623), "Approx. 260 kcal" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated", "NutritionInfo" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3625), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3625), "Approx. 320 kcal" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated", "NutritionInfo" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3627), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3627), "Approx. 550 kcal" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated", "NutritionInfo" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3629), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3630), "Approx. 460 kcal" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated", "NutritionInfo" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3632), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3632), "Approx. 430 kcal" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated", "NutritionInfo" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3670), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3670), "Approx. 540 kcal" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated", "NutritionInfo" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3672), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3673), "Approx. 560 kcal" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated", "NutritionInfo" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3674), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3675), "Approx. 390 kcal" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated", "NutritionInfo" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3677), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3677), "Approx. 240 kcal" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated", "NutritionInfo" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3679), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3680), "Approx. 720 kcal" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated", "NutritionInfo" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3681), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3682), "Approx. 620 kcal" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated", "NutritionInfo" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3684), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3684), "Approx. 740 kcal" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated", "NutritionInfo" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3686), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3687), "Approx. 850 kcal" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated", "NutritionInfo" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3688), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3689), "Approx. 780 kcal" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated", "NutritionInfo" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3691), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3691), "Approx. 920 kcal" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated", "NutritionInfo" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3693), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3694), "Approx. 880 kcal" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated", "NutritionInfo" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3695), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3696), "Approx. 420 kcal" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated", "NutritionInfo" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3698), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3698), "Approx. 680 kcal" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated", "NutritionInfo" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3700), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3700), "Approx. 420 kcal" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated", "NutritionInfo" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3702), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3703), "Approx. 700 kcal" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated", "NutritionInfo" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3705), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3705), "Approx. 640 kcal" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated", "NutritionInfo" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3707), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3707), "Approx. 280 kcal (base)" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated", "NutritionInfo" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3709), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3710), "Approx. 320 kcal (base)" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated", "NutritionInfo" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3712), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3712), "Approx. 90 kcal" });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated", "NutritionInfo" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3714), new DateTime(2026, 1, 16, 1, 1, 15, 600, DateTimeKind.Local).AddTicks(3714), "Approx. 140 kcal" });

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
    }
}
