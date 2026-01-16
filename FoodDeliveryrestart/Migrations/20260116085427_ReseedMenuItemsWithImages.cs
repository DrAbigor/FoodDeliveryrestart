using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodDeliveryrestart.Migrations
{
    /// <inheritdoc />
    public partial class ReseedMenuItemsWithImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1a2b3c4-d5e6-4789-8901-234567890abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "611493d3-56a3-4c05-80c3-2882c93ec65b", "AQAAAAIAAYagAAAAEJVsrR4ZHxOWZLnhGdeBtLne/vdUovIIbflR5uKM9xxME/4Yzen/Kwp2jakSGCkf7Q==", "2116d946-3bb0-434e-80b1-5c72a36d30a2" });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 54, 26, 971, DateTimeKind.Local).AddTicks(5206), new DateTime(2026, 1, 16, 16, 54, 26, 971, DateTimeKind.Local).AddTicks(5216) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 54, 26, 971, DateTimeKind.Local).AddTicks(5217), new DateTime(2026, 1, 16, 16, 54, 26, 971, DateTimeKind.Local).AddTicks(5218) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 54, 26, 971, DateTimeKind.Local).AddTicks(5219), new DateTime(2026, 1, 16, 16, 54, 26, 971, DateTimeKind.Local).AddTicks(5220) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 8, 54, 26, 971, DateTimeKind.Utc).AddTicks(5073), new DateTime(2026, 1, 16, 8, 54, 26, 971, DateTimeKind.Utc).AddTicks(5073) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 8, 54, 26, 971, DateTimeKind.Utc).AddTicks(5075), new DateTime(2026, 1, 16, 8, 54, 26, 971, DateTimeKind.Utc).AddTicks(5076) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 8, 54, 26, 971, DateTimeKind.Utc).AddTicks(5077), new DateTime(2026, 1, 16, 8, 54, 26, 971, DateTimeKind.Utc).AddTicks(5078) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 54, 26, 971, DateTimeKind.Local).AddTicks(5317), new DateTime(2026, 1, 16, 16, 54, 26, 971, DateTimeKind.Local).AddTicks(5318) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 54, 26, 971, DateTimeKind.Local).AddTicks(5321), new DateTime(2026, 1, 16, 16, 54, 26, 971, DateTimeKind.Local).AddTicks(5321) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 54, 26, 971, DateTimeKind.Local).AddTicks(5323), new DateTime(2026, 1, 16, 16, 54, 26, 971, DateTimeKind.Local).AddTicks(5324) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 54, 26, 971, DateTimeKind.Local).AddTicks(5326), new DateTime(2026, 1, 16, 16, 54, 26, 971, DateTimeKind.Local).AddTicks(5326) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 54, 26, 971, DateTimeKind.Local).AddTicks(5328), new DateTime(2026, 1, 16, 16, 54, 26, 971, DateTimeKind.Local).AddTicks(5329) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 54, 26, 971, DateTimeKind.Local).AddTicks(5331), new DateTime(2026, 1, 16, 16, 54, 26, 971, DateTimeKind.Local).AddTicks(5332) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 54, 26, 971, DateTimeKind.Local).AddTicks(5334), new DateTime(2026, 1, 16, 16, 54, 26, 971, DateTimeKind.Local).AddTicks(5334) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 54, 26, 971, DateTimeKind.Local).AddTicks(5336), new DateTime(2026, 1, 16, 16, 54, 26, 971, DateTimeKind.Local).AddTicks(5337) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 54, 26, 971, DateTimeKind.Local).AddTicks(5339), new DateTime(2026, 1, 16, 16, 54, 26, 971, DateTimeKind.Local).AddTicks(5339) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 8, 54, 26, 971, DateTimeKind.Utc).AddTicks(3904), new DateTime(2026, 1, 16, 8, 54, 26, 971, DateTimeKind.Utc).AddTicks(3906) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
