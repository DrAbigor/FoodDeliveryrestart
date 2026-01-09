using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodDeliveryrestart.Migrations
{
    /// <inheritdoc />
    public partial class AddMallAndRestaurantSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 9, 13, 25, 41, 43, DateTimeKind.Utc).AddTicks(7092), new DateTime(2026, 1, 9, 13, 25, 41, 43, DateTimeKind.Utc).AddTicks(7096) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 9, 13, 25, 41, 43, DateTimeKind.Utc).AddTicks(7101), new DateTime(2026, 1, 9, 13, 25, 41, 43, DateTimeKind.Utc).AddTicks(7102) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 9, 13, 25, 41, 43, DateTimeKind.Utc).AddTicks(7107), new DateTime(2026, 1, 9, 13, 25, 41, 43, DateTimeKind.Utc).AddTicks(7108) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 9, 21, 25, 41, 43, DateTimeKind.Local).AddTicks(7905), new DateTime(2026, 1, 9, 21, 25, 41, 43, DateTimeKind.Local).AddTicks(7921) });
        }
    }
}
