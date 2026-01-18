using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodDeliveryrestart.Migrations
{
    /// <inheritdoc />
    public partial class DecimalPrecisionFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Rating",
                table: "Restaurant",
                type: "decimal(2,1)",
                precision: 2,
                scale: 1,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Payment",
                type: "decimal(10,2)",
                precision: 10,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Subtotal",
                table: "OrderItem",
                type: "decimal(10,2)",
                precision: 10,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ItemPrice",
                table: "OrderItem",
                type: "decimal(10,2)",
                precision: 10,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalAmount",
                table: "Order",
                type: "decimal(10,2)",
                precision: 10,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "MenuItem",
                type: "decimal(10,2)",
                precision: 10,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "346b4751-837d-4c9c-8650-ba90283d4f33", "AQAAAAIAAYagAAAAEP274TFLTwVu+K0FRM8IS1ol+9DQmjqAHtHlNO3DN0kKjTHb61MQ4KdzVnh3hagMFQ==", "e5a74813-1874-4f3f-9a6a-2848177c813f" });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 3, 8, 34, 780, DateTimeKind.Local).AddTicks(7235), new DateTime(2026, 1, 18, 3, 8, 34, 780, DateTimeKind.Local).AddTicks(7243) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 3, 8, 34, 780, DateTimeKind.Local).AddTicks(7245), new DateTime(2026, 1, 18, 3, 8, 34, 780, DateTimeKind.Local).AddTicks(7245) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 3, 8, 34, 780, DateTimeKind.Local).AddTicks(7246), new DateTime(2026, 1, 18, 3, 8, 34, 780, DateTimeKind.Local).AddTicks(7247) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 19, 8, 34, 780, DateTimeKind.Utc).AddTicks(7054), new DateTime(2026, 1, 17, 19, 8, 34, 780, DateTimeKind.Utc).AddTicks(7054) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 19, 8, 34, 780, DateTimeKind.Utc).AddTicks(7056), new DateTime(2026, 1, 17, 19, 8, 34, 780, DateTimeKind.Utc).AddTicks(7057) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 19, 8, 34, 780, DateTimeKind.Utc).AddTicks(7109), new DateTime(2026, 1, 17, 19, 8, 34, 780, DateTimeKind.Utc).AddTicks(7110) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 3, 8, 34, 780, DateTimeKind.Local).AddTicks(7343), new DateTime(2026, 1, 18, 3, 8, 34, 780, DateTimeKind.Local).AddTicks(7343) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 3, 8, 34, 780, DateTimeKind.Local).AddTicks(7345), new DateTime(2026, 1, 18, 3, 8, 34, 780, DateTimeKind.Local).AddTicks(7346) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 3, 8, 34, 780, DateTimeKind.Local).AddTicks(7348), new DateTime(2026, 1, 18, 3, 8, 34, 780, DateTimeKind.Local).AddTicks(7348) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 3, 8, 34, 780, DateTimeKind.Local).AddTicks(7351), new DateTime(2026, 1, 18, 3, 8, 34, 780, DateTimeKind.Local).AddTicks(7351) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 3, 8, 34, 780, DateTimeKind.Local).AddTicks(7353), new DateTime(2026, 1, 18, 3, 8, 34, 780, DateTimeKind.Local).AddTicks(7354) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 3, 8, 34, 780, DateTimeKind.Local).AddTicks(7356), new DateTime(2026, 1, 18, 3, 8, 34, 780, DateTimeKind.Local).AddTicks(7356) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 3, 8, 34, 780, DateTimeKind.Local).AddTicks(7358), new DateTime(2026, 1, 18, 3, 8, 34, 780, DateTimeKind.Local).AddTicks(7359) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 3, 8, 34, 780, DateTimeKind.Local).AddTicks(7361), new DateTime(2026, 1, 18, 3, 8, 34, 780, DateTimeKind.Local).AddTicks(7361) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 3, 8, 34, 780, DateTimeKind.Local).AddTicks(7363), new DateTime(2026, 1, 18, 3, 8, 34, 780, DateTimeKind.Local).AddTicks(7364) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 19, 8, 34, 780, DateTimeKind.Utc).AddTicks(6021), new DateTime(2026, 1, 17, 19, 8, 34, 780, DateTimeKind.Utc).AddTicks(6024) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Rating",
                table: "Restaurant",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(2,1)",
                oldPrecision: 2,
                oldScale: 1);

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Payment",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)",
                oldPrecision: 10,
                oldScale: 2);

            migrationBuilder.AlterColumn<decimal>(
                name: "Subtotal",
                table: "OrderItem",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)",
                oldPrecision: 10,
                oldScale: 2);

            migrationBuilder.AlterColumn<decimal>(
                name: "ItemPrice",
                table: "OrderItem",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)",
                oldPrecision: 10,
                oldScale: 2);

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalAmount",
                table: "Order",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)",
                oldPrecision: 10,
                oldScale: 2);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "MenuItem",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)",
                oldPrecision: 10,
                oldScale: 2);

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
    }
}
