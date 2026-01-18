using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodDeliveryrestart.Migrations
{
    /// <inheritdoc />
    public partial class AddVoucherTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Voucher",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscountType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscountValue = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    MinimumOrder = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voucher", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserVoucher",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VoucherId = table.Column<int>(type: "int", nullable: false),
                    ClaimedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsUsed = table.Column<bool>(type: "bit", nullable: false),
                    UsedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserVoucher", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserVoucher_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_UserVoucher_Voucher_VoucherId",
                        column: x => x.VoucherId,
                        principalTable: "Voucher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9bd56e2-f615-4878-95f8-d8b02e2f2129", "AQAAAAIAAYagAAAAELux2cAFNphrLNWIYW2V7JCG0iuRCmjzJDxliTcA1WC6zp8Wmi8ML0HhqA/kCJ0weQ==", "5bf8ea97-bf29-4ce3-b530-ab0102a8299b" });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 22, 15, 2, 699, DateTimeKind.Local).AddTicks(2834), new DateTime(2026, 1, 18, 22, 15, 2, 699, DateTimeKind.Local).AddTicks(2852) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 22, 15, 2, 699, DateTimeKind.Local).AddTicks(2854), new DateTime(2026, 1, 18, 22, 15, 2, 699, DateTimeKind.Local).AddTicks(2855) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 22, 15, 2, 699, DateTimeKind.Local).AddTicks(2856), new DateTime(2026, 1, 18, 22, 15, 2, 699, DateTimeKind.Local).AddTicks(2856) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 14, 15, 2, 699, DateTimeKind.Utc).AddTicks(2679), new DateTime(2026, 1, 18, 14, 15, 2, 699, DateTimeKind.Utc).AddTicks(2680) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 14, 15, 2, 699, DateTimeKind.Utc).AddTicks(2682), new DateTime(2026, 1, 18, 14, 15, 2, 699, DateTimeKind.Utc).AddTicks(2683) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 14, 15, 2, 699, DateTimeKind.Utc).AddTicks(2685), new DateTime(2026, 1, 18, 14, 15, 2, 699, DateTimeKind.Utc).AddTicks(2685) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 22, 15, 2, 699, DateTimeKind.Local).AddTicks(3005), new DateTime(2026, 1, 18, 22, 15, 2, 699, DateTimeKind.Local).AddTicks(3005) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 22, 15, 2, 699, DateTimeKind.Local).AddTicks(3008), new DateTime(2026, 1, 18, 22, 15, 2, 699, DateTimeKind.Local).AddTicks(3008) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 22, 15, 2, 699, DateTimeKind.Local).AddTicks(3010), new DateTime(2026, 1, 18, 22, 15, 2, 699, DateTimeKind.Local).AddTicks(3011) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 22, 15, 2, 699, DateTimeKind.Local).AddTicks(3013), new DateTime(2026, 1, 18, 22, 15, 2, 699, DateTimeKind.Local).AddTicks(3013) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 22, 15, 2, 699, DateTimeKind.Local).AddTicks(3015), new DateTime(2026, 1, 18, 22, 15, 2, 699, DateTimeKind.Local).AddTicks(3015) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 22, 15, 2, 699, DateTimeKind.Local).AddTicks(3017), new DateTime(2026, 1, 18, 22, 15, 2, 699, DateTimeKind.Local).AddTicks(3018) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 22, 15, 2, 699, DateTimeKind.Local).AddTicks(3019), new DateTime(2026, 1, 18, 22, 15, 2, 699, DateTimeKind.Local).AddTicks(3020) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 22, 15, 2, 699, DateTimeKind.Local).AddTicks(3022), new DateTime(2026, 1, 18, 22, 15, 2, 699, DateTimeKind.Local).AddTicks(3022) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 22, 15, 2, 699, DateTimeKind.Local).AddTicks(3024), new DateTime(2026, 1, 18, 22, 15, 2, 699, DateTimeKind.Local).AddTicks(3024) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 14, 15, 2, 699, DateTimeKind.Utc).AddTicks(1240), new DateTime(2026, 1, 18, 14, 15, 2, 699, DateTimeKind.Utc).AddTicks(1245) });

            migrationBuilder.InsertData(
                table: "Voucher",
                columns: new[] { "Id", "Code", "CreatedBy", "DateCreated", "DateUpdated", "Description", "DiscountType", "DiscountValue", "ExpiryDate", "IsActive", "MinimumOrder", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "SAVE20", "System", new DateTime(2026, 1, 18, 14, 15, 2, 700, DateTimeKind.Utc).AddTicks(6638), new DateTime(2026, 1, 18, 14, 15, 2, 700, DateTimeKind.Utc).AddTicks(6640), "Get 20% off your order! Perfect for first-time customers.", "Percentage", 20m, null, true, null, "20% OFF for New Users", "System" },
                    { 2, "FREEDELIVERY15", "System", new DateTime(2026, 1, 18, 14, 15, 2, 700, DateTimeKind.Utc).AddTicks(6646), new DateTime(2026, 1, 18, 14, 15, 2, 700, DateTimeKind.Utc).AddTicks(6646), "Enjoy free delivery when you order $15 or more.", "FreeDelivery", 0m, null, true, 15m, "Free Delivery For Orders Above $15!", "System" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserVoucher_OrderId",
                table: "UserVoucher",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_UserVoucher_VoucherId",
                table: "UserVoucher",
                column: "VoucherId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserVoucher");

            migrationBuilder.DropTable(
                name: "Voucher");

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

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 10, 58, 48, 642, DateTimeKind.Local).AddTicks(7149), new DateTime(2026, 1, 18, 10, 58, 48, 642, DateTimeKind.Local).AddTicks(7150) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 10, 58, 48, 642, DateTimeKind.Local).AddTicks(7152), new DateTime(2026, 1, 18, 10, 58, 48, 642, DateTimeKind.Local).AddTicks(7153) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 10, 58, 48, 642, DateTimeKind.Local).AddTicks(7155), new DateTime(2026, 1, 18, 10, 58, 48, 642, DateTimeKind.Local).AddTicks(7155) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 10, 58, 48, 642, DateTimeKind.Local).AddTicks(7157), new DateTime(2026, 1, 18, 10, 58, 48, 642, DateTimeKind.Local).AddTicks(7158) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 10, 58, 48, 642, DateTimeKind.Local).AddTicks(7160), new DateTime(2026, 1, 18, 10, 58, 48, 642, DateTimeKind.Local).AddTicks(7160) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 10, 58, 48, 642, DateTimeKind.Local).AddTicks(7162), new DateTime(2026, 1, 18, 10, 58, 48, 642, DateTimeKind.Local).AddTicks(7163) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 10, 58, 48, 642, DateTimeKind.Local).AddTicks(7164), new DateTime(2026, 1, 18, 10, 58, 48, 642, DateTimeKind.Local).AddTicks(7165) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 10, 58, 48, 642, DateTimeKind.Local).AddTicks(7167), new DateTime(2026, 1, 18, 10, 58, 48, 642, DateTimeKind.Local).AddTicks(7167) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 10, 58, 48, 642, DateTimeKind.Local).AddTicks(7169), new DateTime(2026, 1, 18, 10, 58, 48, 642, DateTimeKind.Local).AddTicks(7170) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 2, 58, 48, 642, DateTimeKind.Utc).AddTicks(5131), new DateTime(2026, 1, 18, 2, 58, 48, 642, DateTimeKind.Utc).AddTicks(5135) });
        }
    }
}
