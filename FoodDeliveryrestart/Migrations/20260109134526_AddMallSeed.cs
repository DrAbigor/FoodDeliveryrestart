using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodDeliveryrestart.Migrations
{
    /// <inheritdoc />
    public partial class AddMallSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Mall",
                columns: new[] { "Id", "Address", "CreatedBy", "DateCreated", "DateUpdated", "MallName", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "4 Tampines Central 5, Singapore 529510", "Seed", new DateTime(2026, 1, 9, 21, 45, 24, 559, DateTimeKind.Local).AddTicks(1823), new DateTime(2026, 1, 9, 21, 45, 24, 559, DateTimeKind.Local).AddTicks(1837), "Tampines Mall", "Seed" },
                    { 2, "1 HarbourFront Walk, Singapore 098585", "Seed", new DateTime(2026, 1, 9, 21, 45, 24, 559, DateTimeKind.Local).AddTicks(1841), new DateTime(2026, 1, 9, 21, 45, 24, 559, DateTimeKind.Local).AddTicks(1842), "Vivo City", "Seed" },
                    { 3, "181 Orchard Rd, Singapore 238896", "Seed", new DateTime(2026, 1, 9, 21, 45, 24, 559, DateTimeKind.Local).AddTicks(1845), new DateTime(2026, 1, 9, 21, 45, 24, 559, DateTimeKind.Local).AddTicks(1846), "Orchard Central", "Seed" }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 9, 13, 35, 6, 724, DateTimeKind.Utc).AddTicks(9302), new DateTime(2026, 1, 9, 13, 35, 6, 724, DateTimeKind.Utc).AddTicks(9307) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 9, 13, 35, 6, 724, DateTimeKind.Utc).AddTicks(9313), new DateTime(2026, 1, 9, 13, 35, 6, 724, DateTimeKind.Utc).AddTicks(9314) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 9, 13, 35, 6, 724, DateTimeKind.Utc).AddTicks(9318), new DateTime(2026, 1, 9, 13, 35, 6, 724, DateTimeKind.Utc).AddTicks(9319) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 9, 21, 35, 6, 725, DateTimeKind.Local).AddTicks(157), new DateTime(2026, 1, 9, 21, 35, 6, 725, DateTimeKind.Local).AddTicks(158) });
        }
    }
}
