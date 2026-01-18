using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodDeliveryrestart.Migrations
{
    /// <inheritdoc />
    public partial class SplitRestaurantsByMall : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0889b123-a664-428f-96b1-ae97cf4c3740", "AQAAAAIAAYagAAAAEIw9Zx+d3DzpTqL4LjszSRXtcI3sYA54MFg3Bw3LJIpfeczmE7KrGYQ1X1hDGGw/Qw==", "0c967947-419f-4b56-9ab7-e2d1f46d6318" });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 21, 37, 42, 557, DateTimeKind.Local).AddTicks(8914), new DateTime(2026, 1, 18, 21, 37, 42, 557, DateTimeKind.Local).AddTicks(8927) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 21, 37, 42, 557, DateTimeKind.Local).AddTicks(8928), new DateTime(2026, 1, 18, 21, 37, 42, 557, DateTimeKind.Local).AddTicks(8929) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 21, 37, 42, 557, DateTimeKind.Local).AddTicks(8930), new DateTime(2026, 1, 18, 21, 37, 42, 557, DateTimeKind.Local).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 13, 37, 42, 557, DateTimeKind.Utc).AddTicks(8787), new DateTime(2026, 1, 18, 13, 37, 42, 557, DateTimeKind.Utc).AddTicks(8788) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 13, 37, 42, 557, DateTimeKind.Utc).AddTicks(8790), new DateTime(2026, 1, 18, 13, 37, 42, 557, DateTimeKind.Utc).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 13, 37, 42, 557, DateTimeKind.Utc).AddTicks(8792), new DateTime(2026, 1, 18, 13, 37, 42, 557, DateTimeKind.Utc).AddTicks(8792) });

            // ✅ FORCE the correct MallId split for ALL 9 restaurants
            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "MallId" },
                values: new object[] { new DateTime(2026, 1, 18, 21, 37, 42, 557, DateTimeKind.Local).AddTicks(9027), new DateTime(2026, 1, 18, 21, 37, 42, 557, DateTimeKind.Local).AddTicks(9028), 1 });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "MallId" },
                values: new object[] { new DateTime(2026, 1, 18, 21, 37, 42, 557, DateTimeKind.Local).AddTicks(9030), new DateTime(2026, 1, 18, 21, 37, 42, 557, DateTimeKind.Local).AddTicks(9031), 1 });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "MallId" },
                values: new object[] { new DateTime(2026, 1, 18, 21, 37, 42, 557, DateTimeKind.Local).AddTicks(9033), new DateTime(2026, 1, 18, 21, 37, 42, 557, DateTimeKind.Local).AddTicks(9033), 1 });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "MallId" },
                values: new object[] { new DateTime(2026, 1, 18, 21, 37, 42, 557, DateTimeKind.Local).AddTicks(9035), new DateTime(2026, 1, 18, 21, 37, 42, 557, DateTimeKind.Local).AddTicks(9036), 2 });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated", "MallId" },
                values: new object[] { new DateTime(2026, 1, 18, 21, 37, 42, 557, DateTimeKind.Local).AddTicks(9038), new DateTime(2026, 1, 18, 21, 37, 42, 557, DateTimeKind.Local).AddTicks(9038), 2 });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated", "MallId" },
                values: new object[] { new DateTime(2026, 1, 18, 21, 37, 42, 557, DateTimeKind.Local).AddTicks(9041), new DateTime(2026, 1, 18, 21, 37, 42, 557, DateTimeKind.Local).AddTicks(9041), 2 });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated", "MallId" },
                values: new object[] { new DateTime(2026, 1, 18, 21, 37, 42, 557, DateTimeKind.Local).AddTicks(9043), new DateTime(2026, 1, 18, 21, 37, 42, 557, DateTimeKind.Local).AddTicks(9044), 3 });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated", "MallId" },
                values: new object[] { new DateTime(2026, 1, 18, 21, 37, 42, 557, DateTimeKind.Local).AddTicks(9046), new DateTime(2026, 1, 18, 21, 37, 42, 557, DateTimeKind.Local).AddTicks(9046), 3 });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated", "MallId" },
                values: new object[] { new DateTime(2026, 1, 18, 21, 37, 42, 557, DateTimeKind.Local).AddTicks(9048), new DateTime(2026, 1, 18, 21, 37, 42, 557, DateTimeKind.Local).AddTicks(9049), 3 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 13, 37, 42, 557, DateTimeKind.Utc).AddTicks(7800), new DateTime(2026, 1, 18, 13, 37, 42, 557, DateTimeKind.Utc).AddTicks(7804) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0f548ae-6aaf-4ba0-905f-87a107bb0138", "AQAAAAIAAYagAAAAEH+j/FvZxxy4R/JPwvsE49RETcNlGMPfPSoKxJmyTjCpKx4cQMaqRe/SHxDLsBlOcw==", "2acbd5a2-fd4b-4782-b701-533216d21390" });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 10, 58, 48, 642, DateTimeKind.Local).AddTicks(7012), new DateTime(2026, 1, 18, 10, 58, 48, 642, DateTimeKind.Local).AddTicks(7025) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 10, 58, 48, 642, DateTimeKind.Local).AddTicks(7027), new DateTime(2026, 1, 18, 10, 58, 48, 642, DateTimeKind.Local).AddTicks(7027) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 10, 58, 48, 642, DateTimeKind.Local).AddTicks(7028), new DateTime(2026, 1, 18, 10, 58, 48, 642, DateTimeKind.Local).AddTicks(7029) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 2, 58, 48, 642, DateTimeKind.Utc).AddTicks(6828), new DateTime(2026, 1, 18, 2, 58, 48, 642, DateTimeKind.Utc).AddTicks(6829) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 2, 58, 48, 642, DateTimeKind.Utc).AddTicks(6832), new DateTime(2026, 1, 18, 2, 58, 48, 642, DateTimeKind.Utc).AddTicks(6832) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 2, 58, 48, 642, DateTimeKind.Utc).AddTicks(6834), new DateTime(2026, 1, 18, 2, 58, 48, 642, DateTimeKind.Utc).AddTicks(6835) });

            // Down should restore all MallId to 1 (original state)
            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "MallId" },
                values: new object[] { new DateTime(2026, 1, 18, 10, 58, 48, 642, DateTimeKind.Local).AddTicks(7149), new DateTime(2026, 1, 18, 10, 58, 48, 642, DateTimeKind.Local).AddTicks(7150), 1 });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "MallId" },
                values: new object[] { new DateTime(2026, 1, 18, 10, 58, 48, 642, DateTimeKind.Local).AddTicks(7152), new DateTime(2026, 1, 18, 10, 58, 48, 642, DateTimeKind.Local).AddTicks(7153), 1 });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "MallId" },
                values: new object[] { new DateTime(2026, 1, 18, 10, 58, 48, 642, DateTimeKind.Local).AddTicks(7155), new DateTime(2026, 1, 18, 10, 58, 48, 642, DateTimeKind.Local).AddTicks(7155), 1 });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "MallId" },
                values: new object[] { new DateTime(2026, 1, 18, 10, 58, 48, 642, DateTimeKind.Local).AddTicks(7157), new DateTime(2026, 1, 18, 10, 58, 48, 642, DateTimeKind.Local).AddTicks(7158), 1 });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated", "MallId" },
                values: new object[] { new DateTime(2026, 1, 18, 10, 58, 48, 642, DateTimeKind.Local).AddTicks(7160), new DateTime(2026, 1, 18, 10, 58, 48, 642, DateTimeKind.Local).AddTicks(7160), 1 });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated", "MallId" },
                values: new object[] { new DateTime(2026, 1, 18, 10, 58, 48, 642, DateTimeKind.Local).AddTicks(7162), new DateTime(2026, 1, 18, 10, 58, 48, 642, DateTimeKind.Local).AddTicks(7163), 1 });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated", "MallId" },
                values: new object[] { new DateTime(2026, 1, 18, 10, 58, 48, 642, DateTimeKind.Local).AddTicks(7164), new DateTime(2026, 1, 18, 10, 58, 48, 642, DateTimeKind.Local).AddTicks(7165), 1 });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated", "MallId" },
                values: new object[] { new DateTime(2026, 1, 18, 10, 58, 48, 642, DateTimeKind.Local).AddTicks(7167), new DateTime(2026, 1, 18, 10, 58, 48, 642, DateTimeKind.Local).AddTicks(7167), 1 });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated", "MallId" },
                values: new object[] { new DateTime(2026, 1, 18, 10, 58, 48, 642, DateTimeKind.Local).AddTicks(7169), new DateTime(2026, 1, 18, 10, 58, 48, 642, DateTimeKind.Local).AddTicks(7170), 1 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 2, 58, 48, 642, DateTimeKind.Utc).AddTicks(5131), new DateTime(2026, 1, 18, 2, 58, 48, 642, DateTimeKind.Utc).AddTicks(5135) });
        }
    }
}
