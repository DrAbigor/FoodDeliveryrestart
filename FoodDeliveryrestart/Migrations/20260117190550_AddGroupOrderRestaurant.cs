using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodDeliveryrestart.Migrations
{
    /// <inheritdoc />
    public partial class AddGroupOrderRestaurant : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf6b85bf-8e92-492c-b247-98be65322e50", "AQAAAAIAAYagAAAAEDMrd0ElBgJwW7Gsq/j8PKG84uIhRY5mbZJ2Uj6OE0wfpVvHDpRoGG3skdDu0SmfLg==", "7b1bee0b-1d7f-49dd-a199-5a2bcb7eed70" });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 3, 5, 49, 754, DateTimeKind.Local).AddTicks(8412), new DateTime(2026, 1, 18, 3, 5, 49, 754, DateTimeKind.Local).AddTicks(8421) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 3, 5, 49, 754, DateTimeKind.Local).AddTicks(8422), new DateTime(2026, 1, 18, 3, 5, 49, 754, DateTimeKind.Local).AddTicks(8423) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 3, 5, 49, 754, DateTimeKind.Local).AddTicks(8425), new DateTime(2026, 1, 18, 3, 5, 49, 754, DateTimeKind.Local).AddTicks(8425) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 19, 5, 49, 754, DateTimeKind.Utc).AddTicks(8182), new DateTime(2026, 1, 17, 19, 5, 49, 754, DateTimeKind.Utc).AddTicks(8182) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 19, 5, 49, 754, DateTimeKind.Utc).AddTicks(8185), new DateTime(2026, 1, 17, 19, 5, 49, 754, DateTimeKind.Utc).AddTicks(8185) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 19, 5, 49, 754, DateTimeKind.Utc).AddTicks(8187), new DateTime(2026, 1, 17, 19, 5, 49, 754, DateTimeKind.Utc).AddTicks(8187) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 3, 5, 49, 754, DateTimeKind.Local).AddTicks(8565), new DateTime(2026, 1, 18, 3, 5, 49, 754, DateTimeKind.Local).AddTicks(8566) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 3, 5, 49, 754, DateTimeKind.Local).AddTicks(8568), new DateTime(2026, 1, 18, 3, 5, 49, 754, DateTimeKind.Local).AddTicks(8568) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 3, 5, 49, 754, DateTimeKind.Local).AddTicks(8570), new DateTime(2026, 1, 18, 3, 5, 49, 754, DateTimeKind.Local).AddTicks(8571) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 3, 5, 49, 754, DateTimeKind.Local).AddTicks(8573), new DateTime(2026, 1, 18, 3, 5, 49, 754, DateTimeKind.Local).AddTicks(8573) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 3, 5, 49, 754, DateTimeKind.Local).AddTicks(8708), new DateTime(2026, 1, 18, 3, 5, 49, 754, DateTimeKind.Local).AddTicks(8708) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 3, 5, 49, 754, DateTimeKind.Local).AddTicks(8710), new DateTime(2026, 1, 18, 3, 5, 49, 754, DateTimeKind.Local).AddTicks(8711) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 3, 5, 49, 754, DateTimeKind.Local).AddTicks(8713), new DateTime(2026, 1, 18, 3, 5, 49, 754, DateTimeKind.Local).AddTicks(8714) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 3, 5, 49, 754, DateTimeKind.Local).AddTicks(8716), new DateTime(2026, 1, 18, 3, 5, 49, 754, DateTimeKind.Local).AddTicks(8716) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 3, 5, 49, 754, DateTimeKind.Local).AddTicks(8718), new DateTime(2026, 1, 18, 3, 5, 49, 754, DateTimeKind.Local).AddTicks(8719) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 19, 5, 49, 754, DateTimeKind.Utc).AddTicks(7149), new DateTime(2026, 1, 17, 19, 5, 49, 754, DateTimeKind.Utc).AddTicks(7152) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c27fb337-92fb-4100-bbf2-b9a0a52f538c", "AQAAAAIAAYagAAAAEDRmSjFqq37qvWJ5GhDg6dZYyiPoESmyn599ZTE8D1ikoGdcY+444xKgFSvCu2COJA==", "315f97ca-7d75-4872-9e65-1048ee884c26" });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 3, 0, 21, 113, DateTimeKind.Local).AddTicks(3952), new DateTime(2026, 1, 18, 3, 0, 21, 113, DateTimeKind.Local).AddTicks(3962) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 3, 0, 21, 113, DateTimeKind.Local).AddTicks(3964), new DateTime(2026, 1, 18, 3, 0, 21, 113, DateTimeKind.Local).AddTicks(3964) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 3, 0, 21, 113, DateTimeKind.Local).AddTicks(3965), new DateTime(2026, 1, 18, 3, 0, 21, 113, DateTimeKind.Local).AddTicks(3966) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 19, 0, 21, 113, DateTimeKind.Utc).AddTicks(3746), new DateTime(2026, 1, 17, 19, 0, 21, 113, DateTimeKind.Utc).AddTicks(3747) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 19, 0, 21, 113, DateTimeKind.Utc).AddTicks(3748), new DateTime(2026, 1, 17, 19, 0, 21, 113, DateTimeKind.Utc).AddTicks(3749) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 19, 0, 21, 113, DateTimeKind.Utc).AddTicks(3750), new DateTime(2026, 1, 17, 19, 0, 21, 113, DateTimeKind.Utc).AddTicks(3751) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 3, 0, 21, 113, DateTimeKind.Local).AddTicks(4082), new DateTime(2026, 1, 18, 3, 0, 21, 113, DateTimeKind.Local).AddTicks(4082) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 3, 0, 21, 113, DateTimeKind.Local).AddTicks(4085), new DateTime(2026, 1, 18, 3, 0, 21, 113, DateTimeKind.Local).AddTicks(4085) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 3, 0, 21, 113, DateTimeKind.Local).AddTicks(4087), new DateTime(2026, 1, 18, 3, 0, 21, 113, DateTimeKind.Local).AddTicks(4088) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 3, 0, 21, 113, DateTimeKind.Local).AddTicks(4090), new DateTime(2026, 1, 18, 3, 0, 21, 113, DateTimeKind.Local).AddTicks(4090) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 3, 0, 21, 113, DateTimeKind.Local).AddTicks(4092), new DateTime(2026, 1, 18, 3, 0, 21, 113, DateTimeKind.Local).AddTicks(4093) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 3, 0, 21, 113, DateTimeKind.Local).AddTicks(4095), new DateTime(2026, 1, 18, 3, 0, 21, 113, DateTimeKind.Local).AddTicks(4095) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 3, 0, 21, 113, DateTimeKind.Local).AddTicks(4097), new DateTime(2026, 1, 18, 3, 0, 21, 113, DateTimeKind.Local).AddTicks(4098) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 3, 0, 21, 113, DateTimeKind.Local).AddTicks(4100), new DateTime(2026, 1, 18, 3, 0, 21, 113, DateTimeKind.Local).AddTicks(4100) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 3, 0, 21, 113, DateTimeKind.Local).AddTicks(4102), new DateTime(2026, 1, 18, 3, 0, 21, 113, DateTimeKind.Local).AddTicks(4103) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 19, 0, 21, 113, DateTimeKind.Utc).AddTicks(2627), new DateTime(2026, 1, 17, 19, 0, 21, 113, DateTimeKind.Utc).AddTicks(2630) });
        }
    }
}
