using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodDeliveryrestart.Migrations
{
    /// <inheritdoc />
    public partial class AddRestaurantRatingAndBusyLevel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "OperatingHours",
                table: "Restaurant",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Restaurant",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LocationWithinMall",
                table: "Restaurant",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CuisineType",
                table: "Restaurant",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BusyLevel",
                table: "Restaurant",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Rating",
                table: "Restaurant",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1a2b3c4-d5e6-4789-8901-234567890abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b91342d3-a563-482e-94fe-dabd21d640d7", "AQAAAAIAAYagAAAAEEVbpawGOhl5qHkH4/xjBeEeSaGOROoGBFqGKgCisUt3y7MkBhoJdaPkVuaOipvC4g==", "344a7bd1-8027-44e0-8b88-2a25feb3b160" });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 0, 34, 1, 367, DateTimeKind.Local).AddTicks(9085), new DateTime(2026, 1, 16, 0, 34, 1, 367, DateTimeKind.Local).AddTicks(9093) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 0, 34, 1, 367, DateTimeKind.Local).AddTicks(9095), new DateTime(2026, 1, 16, 0, 34, 1, 367, DateTimeKind.Local).AddTicks(9095) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 0, 34, 1, 367, DateTimeKind.Local).AddTicks(9097), new DateTime(2026, 1, 16, 0, 34, 1, 367, DateTimeKind.Local).AddTicks(9097) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 16, 34, 1, 367, DateTimeKind.Utc).AddTicks(8970), new DateTime(2026, 1, 15, 16, 34, 1, 367, DateTimeKind.Utc).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 16, 34, 1, 367, DateTimeKind.Utc).AddTicks(8972), new DateTime(2026, 1, 15, 16, 34, 1, 367, DateTimeKind.Utc).AddTicks(8972) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 16, 34, 1, 367, DateTimeKind.Utc).AddTicks(8974), new DateTime(2026, 1, 15, 16, 34, 1, 367, DateTimeKind.Utc).AddTicks(8974) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BusyLevel", "CreatedBy", "CuisineType", "DateCreated", "DateUpdated", "LocationWithinMall", "Name", "OperatingHours", "Rating", "UpdatedBy" },
                values: new object[] { 1, "Seed", "Fast Food", new DateTime(2026, 1, 16, 0, 34, 1, 367, DateTimeKind.Local).AddTicks(9342), new DateTime(2026, 1, 16, 0, 34, 1, 367, DateTimeKind.Local).AddTicks(9342), "1-24", "A&W", "10am-10pm", 4.4m, "Seed" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BusyLevel", "CuisineType", "DateCreated", "DateUpdated", "LocationWithinMall", "Name", "OperatingHours", "Rating" },
                values: new object[] { 2, "Western", new DateTime(2026, 1, 16, 0, 34, 1, 367, DateTimeKind.Local).AddTicks(9344), new DateTime(2026, 1, 16, 0, 34, 1, 367, DateTimeKind.Local).AddTicks(9345), "1-68", "Burger Lab", "10am-10pm", 4.6m });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BusyLevel", "CuisineType", "DateCreated", "DateUpdated", "LocationWithinMall", "Name", "Rating" },
                values: new object[] { 1, "Fast Food", new DateTime(2026, 1, 16, 0, 34, 1, 367, DateTimeKind.Local).AddTicks(9347), new DateTime(2026, 1, 16, 0, 34, 1, 367, DateTimeKind.Local).AddTicks(9347), "8-90", "Jollibee", 4.7m });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BusyLevel", "CreatedBy", "DateCreated", "DateUpdated", "LocationWithinMall", "MallId", "Name", "Rating" },
                values: new object[] { 2, "Seed", new DateTime(2026, 1, 16, 0, 34, 1, 367, DateTimeKind.Local).AddTicks(9349), new DateTime(2026, 1, 16, 0, 34, 1, 367, DateTimeKind.Local).AddTicks(9350), "8-89", 1, "KFC", 4.2m });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BusyLevel", "DateCreated", "DateUpdated", "LocationWithinMall", "MallId", "Name", "Rating" },
                values: new object[] { 2, new DateTime(2026, 1, 16, 0, 34, 1, 367, DateTimeKind.Local).AddTicks(9352), new DateTime(2026, 1, 16, 0, 34, 1, 367, DateTimeKind.Local).AddTicks(9352), "8-88", 1, "McDonald's", 4.3m });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BusyLevel", "CuisineType", "DateCreated", "DateUpdated", "LocationWithinMall", "MallId", "Name", "OperatingHours", "Rating" },
                values: new object[] { 0, "Western", new DateTime(2026, 1, 16, 0, 34, 1, 367, DateTimeKind.Local).AddTicks(9354), new DateTime(2026, 1, 16, 0, 34, 1, 367, DateTimeKind.Local).AddTicks(9355), "1-67", 1, "Pasta Corner", "24/7", 4.1m });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BusyLevel", "CuisineType", "DateCreated", "DateUpdated", "LocationWithinMall", "MallId", "Name", "OperatingHours", "Rating" },
                values: new object[] { 1, "Western Food", new DateTime(2026, 1, 16, 0, 34, 1, 367, DateTimeKind.Local).AddTicks(9357), new DateTime(2026, 1, 16, 0, 34, 1, 367, DateTimeKind.Local).AddTicks(9357), "1-66", 1, "Pizza House", "24/7", 4.5m });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BusyLevel", "CuisineType", "DateCreated", "DateUpdated", "LocationWithinMall", "MallId", "Name", "Rating" },
                values: new object[] { 1, "Thai Food", new DateTime(2026, 1, 16, 0, 34, 1, 367, DateTimeKind.Local).AddTicks(9359), new DateTime(2026, 1, 16, 0, 34, 1, 367, DateTimeKind.Local).AddTicks(9359), "1-25", 1, "Sanook Kitchen", 4.6m });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BusyLevel", "CuisineType", "DateCreated", "DateUpdated", "LocationWithinMall", "MallId", "Name", "Rating" },
                values: new object[] { 0, "Dessert", new DateTime(2026, 1, 16, 0, 34, 1, 367, DateTimeKind.Local).AddTicks(9361), new DateTime(2026, 1, 16, 0, 34, 1, 367, DateTimeKind.Local).AddTicks(9362), "1-23", 1, "Yochi", 4.8m });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 16, 34, 1, 367, DateTimeKind.Utc).AddTicks(7974), new DateTime(2026, 1, 15, 16, 34, 1, 367, DateTimeKind.Utc).AddTicks(7978) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BusyLevel",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Restaurant");

            migrationBuilder.AlterColumn<string>(
                name: "OperatingHours",
                table: "Restaurant",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Restaurant",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "LocationWithinMall",
                table: "Restaurant",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CuisineType",
                table: "Restaurant",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

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
                columns: new[] { "CreatedBy", "CuisineType", "DateCreated", "DateUpdated", "LocationWithinMall", "Name", "OperatingHours", "UpdatedBy" },
                values: new object[] { "", "Western", new DateTime(2026, 1, 15, 23, 55, 22, 501, DateTimeKind.Local).AddTicks(8790), new DateTime(2026, 1, 15, 23, 55, 22, 501, DateTimeKind.Local).AddTicks(8791), "1-67", "Pasta Corner", "24/7", "" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CuisineType", "DateCreated", "DateUpdated", "LocationWithinMall", "Name", "OperatingHours" },
                values: new object[] { "Western Food", new DateTime(2026, 1, 15, 23, 55, 22, 501, DateTimeKind.Local).AddTicks(8792), new DateTime(2026, 1, 15, 23, 55, 22, 501, DateTimeKind.Local).AddTicks(8793), "1-66", "Pizza House", "24/7" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CuisineType", "DateCreated", "DateUpdated", "LocationWithinMall", "Name" },
                values: new object[] { "Western", new DateTime(2026, 1, 15, 23, 55, 22, 501, DateTimeKind.Local).AddTicks(8794), new DateTime(2026, 1, 15, 23, 55, 22, 501, DateTimeKind.Local).AddTicks(8795), "1-68", "Burger Lab" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "LocationWithinMall", "MallId", "Name" },
                values: new object[] { "Datetime.now", new DateTime(2026, 1, 15, 23, 55, 22, 501, DateTimeKind.Local).AddTicks(8797), new DateTime(2026, 1, 15, 23, 55, 22, 501, DateTimeKind.Local).AddTicks(8797), "8-88", 2, "McDonald's" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated", "LocationWithinMall", "MallId", "Name" },
                values: new object[] { new DateTime(2026, 1, 15, 23, 55, 22, 501, DateTimeKind.Local).AddTicks(8799), new DateTime(2026, 1, 15, 23, 55, 22, 501, DateTimeKind.Local).AddTicks(8799), "8-89", 2, "KFC" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CuisineType", "DateCreated", "DateUpdated", "LocationWithinMall", "MallId", "Name", "OperatingHours" },
                values: new object[] { "Fast Food", new DateTime(2026, 1, 15, 23, 55, 22, 501, DateTimeKind.Local).AddTicks(8801), new DateTime(2026, 1, 15, 23, 55, 22, 501, DateTimeKind.Local).AddTicks(8801), "8-90", 2, "Jollibee", "10am-10pm" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CuisineType", "DateCreated", "DateUpdated", "LocationWithinMall", "MallId", "Name", "OperatingHours" },
                values: new object[] { "Dessert", new DateTime(2026, 1, 15, 23, 55, 22, 501, DateTimeKind.Local).AddTicks(8803), new DateTime(2026, 1, 15, 23, 55, 22, 501, DateTimeKind.Local).AddTicks(8803), "1-23", 3, "Yochi", "10am-10pm" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CuisineType", "DateCreated", "DateUpdated", "LocationWithinMall", "MallId", "Name" },
                values: new object[] { "Fast Food", new DateTime(2026, 1, 15, 23, 55, 22, 501, DateTimeKind.Local).AddTicks(8805), new DateTime(2026, 1, 15, 23, 55, 22, 501, DateTimeKind.Local).AddTicks(8806), "1-24", 3, "A&W" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CuisineType", "DateCreated", "DateUpdated", "LocationWithinMall", "MallId", "Name" },
                values: new object[] { "Thai Food", new DateTime(2026, 1, 15, 23, 55, 22, 501, DateTimeKind.Local).AddTicks(8807), new DateTime(2026, 1, 15, 23, 55, 22, 501, DateTimeKind.Local).AddTicks(8808), "1-25", 3, "Sanook Kitchen" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 15, 55, 22, 501, DateTimeKind.Utc).AddTicks(7617), new DateTime(2026, 1, 15, 15, 55, 22, 501, DateTimeKind.Utc).AddTicks(7619) });
        }
    }
}
