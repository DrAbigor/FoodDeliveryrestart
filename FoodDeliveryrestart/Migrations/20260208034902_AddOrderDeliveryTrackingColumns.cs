using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodDeliveryrestart.Migrations
{
    /// <inheritdoc />
    public partial class AddOrderDeliveryTrackingColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DeliveryStage",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeliveryStageUpdatedUtc",
                table: "Order",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeliveryStartedUtc",
                table: "Order",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "136f2600-f344-468a-a3e7-4b2d22ef15e2", "AQAAAAIAAYagAAAAEMHLVkjMSLby1VOAb3k8DWx+ODtY80hW2sI8qcGIWBR44Oo5Wb8/6U8qq6gsemqrzw==", "296aff18-b930-43ef-9ebb-4819cb6f5f00" });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 11, 49, 1, 7, DateTimeKind.Local).AddTicks(3204), new DateTime(2026, 2, 8, 11, 49, 1, 7, DateTimeKind.Local).AddTicks(3229) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 11, 49, 1, 7, DateTimeKind.Local).AddTicks(3234), new DateTime(2026, 2, 8, 11, 49, 1, 7, DateTimeKind.Local).AddTicks(3235) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 11, 49, 1, 7, DateTimeKind.Local).AddTicks(3238), new DateTime(2026, 2, 8, 11, 49, 1, 7, DateTimeKind.Local).AddTicks(3239) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 3, 49, 1, 7, DateTimeKind.Utc).AddTicks(869), new DateTime(2026, 2, 8, 3, 49, 1, 7, DateTimeKind.Utc).AddTicks(871) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 3, 49, 1, 7, DateTimeKind.Utc).AddTicks(874), new DateTime(2026, 2, 8, 3, 49, 1, 7, DateTimeKind.Utc).AddTicks(875) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 3, 49, 1, 7, DateTimeKind.Utc).AddTicks(878), new DateTime(2026, 2, 8, 3, 49, 1, 7, DateTimeKind.Utc).AddTicks(878) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 11, 49, 1, 7, DateTimeKind.Local).AddTicks(3693), new DateTime(2026, 2, 8, 11, 49, 1, 7, DateTimeKind.Local).AddTicks(3695) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 11, 49, 1, 7, DateTimeKind.Local).AddTicks(3700), new DateTime(2026, 2, 8, 11, 49, 1, 7, DateTimeKind.Local).AddTicks(3701) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 11, 49, 1, 7, DateTimeKind.Local).AddTicks(3705), new DateTime(2026, 2, 8, 11, 49, 1, 7, DateTimeKind.Local).AddTicks(3706) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 11, 49, 1, 7, DateTimeKind.Local).AddTicks(3710), new DateTime(2026, 2, 8, 11, 49, 1, 7, DateTimeKind.Local).AddTicks(3711) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 11, 49, 1, 7, DateTimeKind.Local).AddTicks(3716), new DateTime(2026, 2, 8, 11, 49, 1, 7, DateTimeKind.Local).AddTicks(3717) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 11, 49, 1, 7, DateTimeKind.Local).AddTicks(3721), new DateTime(2026, 2, 8, 11, 49, 1, 7, DateTimeKind.Local).AddTicks(3722) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 11, 49, 1, 7, DateTimeKind.Local).AddTicks(3725), new DateTime(2026, 2, 8, 11, 49, 1, 7, DateTimeKind.Local).AddTicks(3726) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 11, 49, 1, 7, DateTimeKind.Local).AddTicks(3730), new DateTime(2026, 2, 8, 11, 49, 1, 7, DateTimeKind.Local).AddTicks(3746) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 11, 49, 1, 7, DateTimeKind.Local).AddTicks(3750), new DateTime(2026, 2, 8, 11, 49, 1, 7, DateTimeKind.Local).AddTicks(3751) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 3, 49, 1, 6, DateTimeKind.Utc).AddTicks(8135), new DateTime(2026, 2, 8, 3, 49, 1, 6, DateTimeKind.Utc).AddTicks(8143) });

            migrationBuilder.UpdateData(
                table: "Voucher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 3, 49, 1, 12, DateTimeKind.Utc).AddTicks(5717), new DateTime(2026, 2, 8, 3, 49, 1, 12, DateTimeKind.Utc).AddTicks(5719) });

            migrationBuilder.UpdateData(
                table: "Voucher",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 3, 49, 1, 12, DateTimeKind.Utc).AddTicks(5728), new DateTime(2026, 2, 8, 3, 49, 1, 12, DateTimeKind.Utc).AddTicks(5729) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeliveryStage",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "DeliveryStageUpdatedUtc",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "DeliveryStartedUtc",
                table: "Order");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "726b05e2-889d-4e49-91ed-e09836580469", "AQAAAAIAAYagAAAAEOCR54w9YNZ1DEZglTTFF3sQ3ZXbSIKFJuf+3NtvKQ0jLSKHLByenlN/lLi9cbDGvA==", "e4db6840-91ab-4cdc-af8d-c2d07a60bfad" });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 28, 48, 134, DateTimeKind.Local).AddTicks(4749), new DateTime(2026, 2, 3, 14, 28, 48, 134, DateTimeKind.Local).AddTicks(4762) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 28, 48, 134, DateTimeKind.Local).AddTicks(4763), new DateTime(2026, 2, 3, 14, 28, 48, 134, DateTimeKind.Local).AddTicks(4763) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 28, 48, 134, DateTimeKind.Local).AddTicks(4765), new DateTime(2026, 2, 3, 14, 28, 48, 134, DateTimeKind.Local).AddTicks(4765) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 3, 6, 28, 48, 134, DateTimeKind.Utc).AddTicks(4597), new DateTime(2026, 2, 3, 6, 28, 48, 134, DateTimeKind.Utc).AddTicks(4597) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 3, 6, 28, 48, 134, DateTimeKind.Utc).AddTicks(4601), new DateTime(2026, 2, 3, 6, 28, 48, 134, DateTimeKind.Utc).AddTicks(4601) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 3, 6, 28, 48, 134, DateTimeKind.Utc).AddTicks(4603), new DateTime(2026, 2, 3, 6, 28, 48, 134, DateTimeKind.Utc).AddTicks(4603) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 28, 48, 134, DateTimeKind.Local).AddTicks(4913), new DateTime(2026, 2, 3, 14, 28, 48, 134, DateTimeKind.Local).AddTicks(4914) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 28, 48, 134, DateTimeKind.Local).AddTicks(4917), new DateTime(2026, 2, 3, 14, 28, 48, 134, DateTimeKind.Local).AddTicks(4918) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 28, 48, 134, DateTimeKind.Local).AddTicks(4920), new DateTime(2026, 2, 3, 14, 28, 48, 134, DateTimeKind.Local).AddTicks(4920) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 28, 48, 134, DateTimeKind.Local).AddTicks(4922), new DateTime(2026, 2, 3, 14, 28, 48, 134, DateTimeKind.Local).AddTicks(4922) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 28, 48, 134, DateTimeKind.Local).AddTicks(4924), new DateTime(2026, 2, 3, 14, 28, 48, 134, DateTimeKind.Local).AddTicks(4925) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 28, 48, 134, DateTimeKind.Local).AddTicks(5050), new DateTime(2026, 2, 3, 14, 28, 48, 134, DateTimeKind.Local).AddTicks(5050) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 28, 48, 134, DateTimeKind.Local).AddTicks(5052), new DateTime(2026, 2, 3, 14, 28, 48, 134, DateTimeKind.Local).AddTicks(5053) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 28, 48, 134, DateTimeKind.Local).AddTicks(5055), new DateTime(2026, 2, 3, 14, 28, 48, 134, DateTimeKind.Local).AddTicks(5055) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 28, 48, 134, DateTimeKind.Local).AddTicks(5057), new DateTime(2026, 2, 3, 14, 28, 48, 134, DateTimeKind.Local).AddTicks(5058) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 3, 6, 28, 48, 134, DateTimeKind.Utc).AddTicks(3344), new DateTime(2026, 2, 3, 6, 28, 48, 134, DateTimeKind.Utc).AddTicks(3351) });

            migrationBuilder.UpdateData(
                table: "Voucher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 3, 6, 28, 48, 135, DateTimeKind.Utc).AddTicks(7762), new DateTime(2026, 2, 3, 6, 28, 48, 135, DateTimeKind.Utc).AddTicks(7763) });

            migrationBuilder.UpdateData(
                table: "Voucher",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 3, 6, 28, 48, 135, DateTimeKind.Utc).AddTicks(7769), new DateTime(2026, 2, 3, 6, 28, 48, 135, DateTimeKind.Utc).AddTicks(7770) });
        }
    }
}
