using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodDeliveryrestart.Migrations
{
    /// <inheritdoc />
    public partial class AddRestaurantImageUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Restaurant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1a2b3c4-d5e6-4789-8901-234567890abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05bc2b01-372b-4f28-acb6-f8a580d8ed45", "AQAAAAIAAYagAAAAEF/0iRalRgywZqg4G3PSwsF8XVSZ20kAl3dfDmKGTmEPPEfjWvLG0KnxG/bucdf5NQ==", "f6d29609-f957-4ebe-b808-17fe83c9bc82" });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(4786), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(4795) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(4796), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(4797) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(4798), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(4799) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5037), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5038), true, true });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5040), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5041), true, true, true });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree", "IsVegan" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5043), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5044), true, true, true, true });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5046), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5047), true, true });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5049), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5050), true, true, true });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5053), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5053), true, true, true });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree", "IsVegan" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5056), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5056), true, true, true, true });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree", "IsVegan" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5059), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5059), true, true, true, true });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5062), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5062), true, true, true });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5065), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5065), true, true, true });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5068), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5068), true, true, true });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree", "IsVegan" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5071), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5071), true, true, true, true });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5074), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5074), true, true, true });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5077), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5078), true, true });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5080), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5081), true, true });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5085), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5085), true, true, true });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5088), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5088), true, true });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5091), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5091), true, true, true });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5094), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5094), true, true });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree", "IsVegan" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5097), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5097), true, true, true, true });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5100), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5100), true, true });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree", "IsVegan" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5103), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5103), true, true, true, true });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5106), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5106), true, true, true });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5109), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5109), true, true });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5112), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5112), true, true });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5115), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5115), true, true });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5118), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5118), true, true });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5121), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5121), true, true });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5124), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5125), true, true });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5127), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5128), true, true });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5156), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5156), true, true });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5159), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5160), true, true, true });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5162), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5163), true, true });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5165), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5166), true, true });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree", "IsVegan" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5168), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5169), true, true, true, true });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5172), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5172), true, true });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 3, 33, 17, 176, DateTimeKind.Utc).AddTicks(4656), new DateTime(2026, 1, 16, 3, 33, 17, 176, DateTimeKind.Utc).AddTicks(4657) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 3, 33, 17, 176, DateTimeKind.Utc).AddTicks(4659), new DateTime(2026, 1, 16, 3, 33, 17, 176, DateTimeKind.Utc).AddTicks(4659) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 3, 33, 17, 176, DateTimeKind.Utc).AddTicks(4661), new DateTime(2026, 1, 16, 3, 33, 17, 176, DateTimeKind.Utc).AddTicks(4661) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(4900), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(4901), "https://upload.wikimedia.org/wikipedia/commons/6/6f/A%26W_Restaurants_logo.svg" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(4903), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(4903), "https://images.unsplash.com/photo-1550547660-d9450f859349" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(4905), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(4906), "https://upload.wikimedia.org/wikipedia/en/5/5e/Jollibee_Logo.svg" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(4908), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(4909), "https://upload.wikimedia.org/wikipedia/sco/b/bf/KFC_logo.svg" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(4911), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(4911), "https://upload.wikimedia.org/wikipedia/commons/4/4b/McDonald%27s_logo.svg" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(4913), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(4914), "https://images.unsplash.com/photo-1521389508051-d7ffb5dc8f6f" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(4916), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(4916), "https://images.unsplash.com/photo-1548365328-8b849e6a1e05" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(4918), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(4919), "https://images.unsplash.com/photo-1559847844-5315695dadae" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(4921), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(4921), "https://images.unsplash.com/photo-1551024601-bec78aea704b" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 3, 33, 17, 176, DateTimeKind.Utc).AddTicks(3549), new DateTime(2026, 1, 16, 3, 33, 17, 176, DateTimeKind.Utc).AddTicks(3551) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Restaurant");

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
                columns: new[] { "DateCreated", "DateUpdated", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5494), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5494), false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5496), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5497), false, false, false });

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
                columns: new[] { "DateCreated", "DateUpdated", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5502), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5502), false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5504), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5505), false, false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5507), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5507), false, false, false });

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
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5515), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5515), false, false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5517), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5518), false, false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5520), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5521), false, false, false });

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
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5525), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5526), false, false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5528), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5529), false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5531), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5531), false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5533), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5534), false, false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5536), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5537), false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5539), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5539), false, false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5541), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5542), false, false });

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
                columns: new[] { "DateCreated", "DateUpdated", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5547), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5547), false, false });

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
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5552), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5552), false, false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5554), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5555), false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5587), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5588), false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5590), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5591), false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5593), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5593), false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5596), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5596), false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5598), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5599), false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5601), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5601), false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5604), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5604), false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated", "IsDairyFree", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5606), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5607), false, false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5609), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5609), false, false });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5611), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5612), false, false });

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
                columns: new[] { "DateCreated", "DateUpdated", "IsHalal", "IsNutFree" },
                values: new object[] { new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5617), new DateTime(2026, 1, 16, 1, 43, 4, 908, DateTimeKind.Local).AddTicks(5617), false, false });

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
    }
}
