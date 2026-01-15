using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodDeliveryrestart.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1a2b3c4-d5e6-4789-8901-234567890abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "821400f3-9a72-4b22-9552-6f3c342621d9", "AQAAAAIAAYagAAAAEAFZgVR5ZMQ90yqZ1txse5UVj4A3octfCMuPwPzyWEupYrk9QzuY1iiPdPK9NVuLJw==", "479289d4-3e56-48eb-9eb0-7895a3af07de" });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 23, 55, 22, 501, DateTimeKind.Local).AddTicks(8685), new DateTime(2026, 1, 15, 23, 55, 22, 501, DateTimeKind.Local).AddTicks(8694) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 23, 55, 22, 501, DateTimeKind.Local).AddTicks(8695), new DateTime(2026, 1, 15, 23, 55, 22, 501, DateTimeKind.Local).AddTicks(8696) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 23, 55, 22, 501, DateTimeKind.Local).AddTicks(8697), new DateTime(2026, 1, 15, 23, 55, 22, 501, DateTimeKind.Local).AddTicks(8698) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 15, 55, 22, 501, DateTimeKind.Utc).AddTicks(8479), new DateTime(2026, 1, 15, 15, 55, 22, 501, DateTimeKind.Utc).AddTicks(8480) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 15, 55, 22, 501, DateTimeKind.Utc).AddTicks(8482), new DateTime(2026, 1, 15, 15, 55, 22, 501, DateTimeKind.Utc).AddTicks(8482) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 15, 55, 22, 501, DateTimeKind.Utc).AddTicks(8484), new DateTime(2026, 1, 15, 15, 55, 22, 501, DateTimeKind.Utc).AddTicks(8484) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 23, 55, 22, 501, DateTimeKind.Local).AddTicks(8790), new DateTime(2026, 1, 15, 23, 55, 22, 501, DateTimeKind.Local).AddTicks(8791) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 23, 55, 22, 501, DateTimeKind.Local).AddTicks(8792), new DateTime(2026, 1, 15, 23, 55, 22, 501, DateTimeKind.Local).AddTicks(8793) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 23, 55, 22, 501, DateTimeKind.Local).AddTicks(8794), new DateTime(2026, 1, 15, 23, 55, 22, 501, DateTimeKind.Local).AddTicks(8795) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 23, 55, 22, 501, DateTimeKind.Local).AddTicks(8797), new DateTime(2026, 1, 15, 23, 55, 22, 501, DateTimeKind.Local).AddTicks(8797) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 23, 55, 22, 501, DateTimeKind.Local).AddTicks(8799), new DateTime(2026, 1, 15, 23, 55, 22, 501, DateTimeKind.Local).AddTicks(8799) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 23, 55, 22, 501, DateTimeKind.Local).AddTicks(8801), new DateTime(2026, 1, 15, 23, 55, 22, 501, DateTimeKind.Local).AddTicks(8801) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 23, 55, 22, 501, DateTimeKind.Local).AddTicks(8803), new DateTime(2026, 1, 15, 23, 55, 22, 501, DateTimeKind.Local).AddTicks(8803) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 23, 55, 22, 501, DateTimeKind.Local).AddTicks(8805), new DateTime(2026, 1, 15, 23, 55, 22, 501, DateTimeKind.Local).AddTicks(8806) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 23, 55, 22, 501, DateTimeKind.Local).AddTicks(8807), new DateTime(2026, 1, 15, 23, 55, 22, 501, DateTimeKind.Local).AddTicks(8808) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 15, 55, 22, 501, DateTimeKind.Utc).AddTicks(7617), new DateTime(2026, 1, 15, 15, 55, 22, 501, DateTimeKind.Utc).AddTicks(7619) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1a2b3c4-d5e6-4789-8901-234567890abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "311596ec-c05e-4e51-ac60-91601886a0cf", "AQAAAAIAAYagAAAAEAknbbAIkoRVJmeUFD0D7smSm0VSfeU/M5POUlOSsfWphCB/ZL/mlGkd7Lf05QBLEQ==", "0aa301c9-56b9-4606-abb1-e33d01a85fb0" });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 19, 18, 34, 53, DateTimeKind.Local).AddTicks(8731), new DateTime(2026, 1, 14, 19, 18, 34, 53, DateTimeKind.Local).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 19, 18, 34, 53, DateTimeKind.Local).AddTicks(8747), new DateTime(2026, 1, 14, 19, 18, 34, 53, DateTimeKind.Local).AddTicks(8747) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 19, 18, 34, 53, DateTimeKind.Local).AddTicks(8748), new DateTime(2026, 1, 14, 19, 18, 34, 53, DateTimeKind.Local).AddTicks(8749) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 11, 18, 34, 53, DateTimeKind.Utc).AddTicks(8484), new DateTime(2026, 1, 14, 11, 18, 34, 53, DateTimeKind.Utc).AddTicks(8485) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 11, 18, 34, 53, DateTimeKind.Utc).AddTicks(8578), new DateTime(2026, 1, 14, 11, 18, 34, 53, DateTimeKind.Utc).AddTicks(8578) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 11, 18, 34, 53, DateTimeKind.Utc).AddTicks(8581), new DateTime(2026, 1, 14, 11, 18, 34, 53, DateTimeKind.Utc).AddTicks(8581) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 19, 18, 34, 53, DateTimeKind.Local).AddTicks(8879), new DateTime(2026, 1, 14, 19, 18, 34, 53, DateTimeKind.Local).AddTicks(8879) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 19, 18, 34, 53, DateTimeKind.Local).AddTicks(8881), new DateTime(2026, 1, 14, 19, 18, 34, 53, DateTimeKind.Local).AddTicks(8882) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 19, 18, 34, 53, DateTimeKind.Local).AddTicks(8883), new DateTime(2026, 1, 14, 19, 18, 34, 53, DateTimeKind.Local).AddTicks(8884) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 19, 18, 34, 53, DateTimeKind.Local).AddTicks(8885), new DateTime(2026, 1, 14, 19, 18, 34, 53, DateTimeKind.Local).AddTicks(8886) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 19, 18, 34, 53, DateTimeKind.Local).AddTicks(8887), new DateTime(2026, 1, 14, 19, 18, 34, 53, DateTimeKind.Local).AddTicks(8888) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 19, 18, 34, 53, DateTimeKind.Local).AddTicks(8889), new DateTime(2026, 1, 14, 19, 18, 34, 53, DateTimeKind.Local).AddTicks(8889) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 19, 18, 34, 53, DateTimeKind.Local).AddTicks(8891), new DateTime(2026, 1, 14, 19, 18, 34, 53, DateTimeKind.Local).AddTicks(8891) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 19, 18, 34, 53, DateTimeKind.Local).AddTicks(8893), new DateTime(2026, 1, 14, 19, 18, 34, 53, DateTimeKind.Local).AddTicks(8893) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 19, 18, 34, 53, DateTimeKind.Local).AddTicks(8895), new DateTime(2026, 1, 14, 19, 18, 34, 53, DateTimeKind.Local).AddTicks(8895) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 11, 18, 34, 53, DateTimeKind.Utc).AddTicks(7238), new DateTime(2026, 1, 14, 11, 18, 34, 53, DateTimeKind.Utc).AddTicks(7243) });
        }
    }
}
