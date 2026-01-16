using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodDeliveryrestart.Migrations
{
    /// <inheritdoc />
    public partial class AddMenuItemImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "MenuItem",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1a2b3c4-d5e6-4789-8901-234567890abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd4321aa-cbd2-4175-9f27-274c3fa3c150", "AQAAAAIAAYagAAAAEIKUzAt+gLqlEtR6bVAJGYUAmxlwqw5xm8U13Rc1/ZOWx4ru3nFtXcYmZKlgTImiPw==", "8324c9c1-958d-46a2-8293-9e3271a8b41c" });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2121), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2130) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2131), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2132) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2133), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2134) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2368), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2369), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2371), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2372), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2374), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2375), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2412), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2413), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2416), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2416), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2419), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2419), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2422), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2423), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2425), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2426), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2429), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2429), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2432), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2432), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2435), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2435), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2438), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2439), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2441), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2442), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2444), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2445), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2448), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2448), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2451), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2451), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2454), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2454), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2457), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2457), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2460), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2461), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2463), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2464), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2466), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2467), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2469), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2470), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2473), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2473), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2476), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2476), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2479), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2480), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2482), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2483), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2485), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2486), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2488), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2489), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2492), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2492), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2495), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2495), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2498), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2499), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2501), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2502), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2505), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2505), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2508), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2508), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2511), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2512), null });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2514), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2515), null });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 8, 28, 33, 476, DateTimeKind.Utc).AddTicks(1992), new DateTime(2026, 1, 16, 8, 28, 33, 476, DateTimeKind.Utc).AddTicks(1993) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 8, 28, 33, 476, DateTimeKind.Utc).AddTicks(1995), new DateTime(2026, 1, 16, 8, 28, 33, 476, DateTimeKind.Utc).AddTicks(1996) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 8, 28, 33, 476, DateTimeKind.Utc).AddTicks(1997), new DateTime(2026, 1, 16, 8, 28, 33, 476, DateTimeKind.Utc).AddTicks(1998) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2229), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2230) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2232), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2233) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2235), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2236) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2238), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2238) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2240), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2241) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2244), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2245) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2247), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2248) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2250), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2250) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2256), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2257) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 8, 28, 33, 476, DateTimeKind.Utc).AddTicks(999), new DateTime(2026, 1, 16, 8, 28, 33, 476, DateTimeKind.Utc).AddTicks(1004) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "MenuItem");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1a2b3c4-d5e6-4789-8901-234567890abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "147f26b2-bd65-4e1b-9f42-0105f6f47f7f", "AQAAAAIAAYagAAAAEI1pft148y/+D0nNEiqZXkre5SYV0JQLcZjMipHdImt1B4hD9qEMWyDwyuJnXI5aAA==", "7b5d1a90-05fa-48ab-9853-8b8f6be53c7f" });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3588), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3595) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3596), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3597) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3598), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3599) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3883), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3884) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3887), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3887) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3890), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3890) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3893), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3894) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3896), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3897) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3899), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3900) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3902), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3903) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3905), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3906) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3908), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3909) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3911), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3912) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3914), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3915) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3918), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3918) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3921), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3921) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3924), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3924) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3927), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3927) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3930), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3930) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3933), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3933) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3936), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3936) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3939), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3939) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3942), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3943) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3945), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3946) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3948), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3949) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3951), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3952) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3954), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3955) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3957), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3958) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3960), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3961) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3964), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3964) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3967), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3967) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3970), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3970) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3973), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3973) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3976), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3976) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3979), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3979) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3982), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3983) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3985), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3986) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3988), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3989) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3991), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3992) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 4, 19, 19, 254, DateTimeKind.Utc).AddTicks(3438), new DateTime(2026, 1, 16, 4, 19, 19, 254, DateTimeKind.Utc).AddTicks(3439) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 4, 19, 19, 254, DateTimeKind.Utc).AddTicks(3440), new DateTime(2026, 1, 16, 4, 19, 19, 254, DateTimeKind.Utc).AddTicks(3441) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 4, 19, 19, 254, DateTimeKind.Utc).AddTicks(3443), new DateTime(2026, 1, 16, 4, 19, 19, 254, DateTimeKind.Utc).AddTicks(3443) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3691), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3692) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3694), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3695) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3697), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3697) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3699), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3700) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3702), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3702) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3704), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3705) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3707), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3707) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3709), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3710) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3712), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3713) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 4, 19, 19, 254, DateTimeKind.Utc).AddTicks(2263), new DateTime(2026, 1, 16, 4, 19, 19, 254, DateTimeKind.Utc).AddTicks(2267) });
        }
    }
}
