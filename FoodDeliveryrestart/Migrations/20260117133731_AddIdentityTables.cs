using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodDeliveryrestart.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentityTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c8a7f5a-94cb-4da6-b2be-cf3fe7c69f6d", "AQAAAAIAAYagAAAAEKOcO5ZSpi+75W6s8qEgviLz4Of/zXKK0NozghhsZJSlSUUbjWlKSRpCVdaRc+Pe8A==", "be01a0e4-1598-412f-8a0e-6eccc0f43c60" });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 21, 37, 31, 161, DateTimeKind.Local).AddTicks(5282), new DateTime(2026, 1, 17, 21, 37, 31, 161, DateTimeKind.Local).AddTicks(5298) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 21, 37, 31, 161, DateTimeKind.Local).AddTicks(5300), new DateTime(2026, 1, 17, 21, 37, 31, 161, DateTimeKind.Local).AddTicks(5300) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 21, 37, 31, 161, DateTimeKind.Local).AddTicks(5302), new DateTime(2026, 1, 17, 21, 37, 31, 161, DateTimeKind.Local).AddTicks(5302) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 13, 37, 31, 161, DateTimeKind.Utc).AddTicks(5072), new DateTime(2026, 1, 17, 13, 37, 31, 161, DateTimeKind.Utc).AddTicks(5073) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 13, 37, 31, 161, DateTimeKind.Utc).AddTicks(5075), new DateTime(2026, 1, 17, 13, 37, 31, 161, DateTimeKind.Utc).AddTicks(5076) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 13, 37, 31, 161, DateTimeKind.Utc).AddTicks(5078), new DateTime(2026, 1, 17, 13, 37, 31, 161, DateTimeKind.Utc).AddTicks(5078) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 21, 37, 31, 161, DateTimeKind.Local).AddTicks(5428), new DateTime(2026, 1, 17, 21, 37, 31, 161, DateTimeKind.Local).AddTicks(5428) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 21, 37, 31, 161, DateTimeKind.Local).AddTicks(5431), new DateTime(2026, 1, 17, 21, 37, 31, 161, DateTimeKind.Local).AddTicks(5432) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 21, 37, 31, 161, DateTimeKind.Local).AddTicks(5434), new DateTime(2026, 1, 17, 21, 37, 31, 161, DateTimeKind.Local).AddTicks(5434) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 21, 37, 31, 161, DateTimeKind.Local).AddTicks(5566), new DateTime(2026, 1, 17, 21, 37, 31, 161, DateTimeKind.Local).AddTicks(5567) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 21, 37, 31, 161, DateTimeKind.Local).AddTicks(5569), new DateTime(2026, 1, 17, 21, 37, 31, 161, DateTimeKind.Local).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 21, 37, 31, 161, DateTimeKind.Local).AddTicks(5572), new DateTime(2026, 1, 17, 21, 37, 31, 161, DateTimeKind.Local).AddTicks(5572) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 21, 37, 31, 161, DateTimeKind.Local).AddTicks(5574), new DateTime(2026, 1, 17, 21, 37, 31, 161, DateTimeKind.Local).AddTicks(5575) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 21, 37, 31, 161, DateTimeKind.Local).AddTicks(5577), new DateTime(2026, 1, 17, 21, 37, 31, 161, DateTimeKind.Local).AddTicks(5577) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 21, 37, 31, 161, DateTimeKind.Local).AddTicks(5579), new DateTime(2026, 1, 17, 21, 37, 31, 161, DateTimeKind.Local).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 13, 37, 31, 161, DateTimeKind.Utc).AddTicks(3716), new DateTime(2026, 1, 17, 13, 37, 31, 161, DateTimeKind.Utc).AddTicks(3723) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a0e0dc2-0c6b-4147-b542-10910844be54", "AQAAAAIAAYagAAAAEEdqYFc8P4R5pkL8EHnnG0a5tV8tIMstfldQUFYrQWYP9Nd+f8PzObDMXDI5xoGuOQ==", "98b4ffb2-a8b4-4efe-a8e6-9e263abb8830" });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 21, 10, 26, 889, DateTimeKind.Local).AddTicks(4762), new DateTime(2026, 1, 17, 21, 10, 26, 889, DateTimeKind.Local).AddTicks(4777) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 21, 10, 26, 889, DateTimeKind.Local).AddTicks(4778), new DateTime(2026, 1, 17, 21, 10, 26, 889, DateTimeKind.Local).AddTicks(4779) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 21, 10, 26, 889, DateTimeKind.Local).AddTicks(4780), new DateTime(2026, 1, 17, 21, 10, 26, 889, DateTimeKind.Local).AddTicks(4781) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 13, 10, 26, 889, DateTimeKind.Utc).AddTicks(4566), new DateTime(2026, 1, 17, 13, 10, 26, 889, DateTimeKind.Utc).AddTicks(4567) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 13, 10, 26, 889, DateTimeKind.Utc).AddTicks(4574), new DateTime(2026, 1, 17, 13, 10, 26, 889, DateTimeKind.Utc).AddTicks(4575) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 13, 10, 26, 889, DateTimeKind.Utc).AddTicks(4577), new DateTime(2026, 1, 17, 13, 10, 26, 889, DateTimeKind.Utc).AddTicks(4577) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 21, 10, 26, 889, DateTimeKind.Local).AddTicks(4907), new DateTime(2026, 1, 17, 21, 10, 26, 889, DateTimeKind.Local).AddTicks(4907) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 21, 10, 26, 889, DateTimeKind.Local).AddTicks(4909), new DateTime(2026, 1, 17, 21, 10, 26, 889, DateTimeKind.Local).AddTicks(4910) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 21, 10, 26, 889, DateTimeKind.Local).AddTicks(4912), new DateTime(2026, 1, 17, 21, 10, 26, 889, DateTimeKind.Local).AddTicks(4913) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 21, 10, 26, 889, DateTimeKind.Local).AddTicks(4914), new DateTime(2026, 1, 17, 21, 10, 26, 889, DateTimeKind.Local).AddTicks(4915) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 21, 10, 26, 889, DateTimeKind.Local).AddTicks(4917), new DateTime(2026, 1, 17, 21, 10, 26, 889, DateTimeKind.Local).AddTicks(4917) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 21, 10, 26, 889, DateTimeKind.Local).AddTicks(4919), new DateTime(2026, 1, 17, 21, 10, 26, 889, DateTimeKind.Local).AddTicks(4920) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 21, 10, 26, 889, DateTimeKind.Local).AddTicks(4921), new DateTime(2026, 1, 17, 21, 10, 26, 889, DateTimeKind.Local).AddTicks(4922) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 21, 10, 26, 889, DateTimeKind.Local).AddTicks(4924), new DateTime(2026, 1, 17, 21, 10, 26, 889, DateTimeKind.Local).AddTicks(4924) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 21, 10, 26, 889, DateTimeKind.Local).AddTicks(4926), new DateTime(2026, 1, 17, 21, 10, 26, 889, DateTimeKind.Local).AddTicks(4926) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 13, 10, 26, 889, DateTimeKind.Utc).AddTicks(3319), new DateTime(2026, 1, 17, 13, 10, 26, 889, DateTimeKind.Utc).AddTicks(3327) });
        }
    }
}
