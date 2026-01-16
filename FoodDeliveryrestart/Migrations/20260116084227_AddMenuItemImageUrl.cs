using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodDeliveryrestart.Migrations
{
    /// <inheritdoc />
    public partial class AddMenuItemImageUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9412), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9413) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9415), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9416) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9418), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9419) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9421), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9422) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9425), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9425) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9428), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9428) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9431), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9431) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9434), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9435) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9437), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9438) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9440), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9441) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9444), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9444) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9447), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9447) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9450), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9450) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9453), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9454) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9456), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9457) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9459), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9460) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9462), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9463) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9465), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9466) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9469), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9469) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9472), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9472) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9475), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9475) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9478), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9479) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9481), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9482) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9484), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9485) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9488), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9489) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9493), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9494) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9497), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9498) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9501), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9501) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9504), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9504) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9507), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9507) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9510), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9511) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9513), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9514) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9516), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9517) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9520), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9520) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9523), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9523) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9526), new DateTime(2026, 1, 16, 16, 42, 26, 589, DateTimeKind.Local).AddTicks(9526) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2368), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2369) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2371), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2372) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2374), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2375) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2412), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2413) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2416), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2416) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2419), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2419) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2422), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2423) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2425), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2426) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2429), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2429) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2432), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2432) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2435), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2435) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2438), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2439) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2441), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2442) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2444), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2445) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2448), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2448) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2451), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2451) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2454), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2454) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2457), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2457) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2460), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2461) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2463), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2464) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2466), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2467) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2469), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2470) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2473), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2473) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2476), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2476) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2479), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2482), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2483) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2485), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2486) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2488), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2489) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2492), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2492) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2495), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2495) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2498), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2499) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2501), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2502) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2505), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2505) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2508), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2508) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2511), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2512) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2514), new DateTime(2026, 1, 16, 16, 28, 33, 476, DateTimeKind.Local).AddTicks(2515) });

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
    }
}
