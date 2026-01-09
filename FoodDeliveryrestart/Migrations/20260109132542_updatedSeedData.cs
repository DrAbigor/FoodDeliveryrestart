using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodDeliveryrestart.Migrations
{
    /// <inheritdoc />
    public partial class updatedSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethod_User_UserId",
                table: "PaymentMethod");

            migrationBuilder.AlterColumn<string>(
                name: "CardType",
                table: "PaymentMethod",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CardHolderName",
                table: "PaymentMethod",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Email", "Name", "Password", "PhoneNumber", "UpdatedBy" },
                values: new object[] { 1, "Seed", new DateTime(2026, 1, 9, 21, 25, 41, 43, DateTimeKind.Local).AddTicks(7905), new DateTime(2026, 1, 9, 21, 25, 41, 43, DateTimeKind.Local).AddTicks(7921), "seed@food.com", "Seed User", "Password123", null, "Seed" });

            migrationBuilder.InsertData(
                table: "PaymentMethod",
                columns: new[] { "Id", "CardHolderName", "CardType", "CreatedBy", "DateCreated", "DateUpdated", "ExpiryMonth", "ExpiryYear", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { 1, "Seed User", "Visa", "Seed", new DateTime(2026, 1, 9, 13, 25, 41, 43, DateTimeKind.Utc).AddTicks(7092), new DateTime(2026, 1, 9, 13, 25, 41, 43, DateTimeKind.Utc).AddTicks(7096), 12, 2026, "Seed", 1 },
                    { 2, "Seed User", "MasterCard", "Seed", new DateTime(2026, 1, 9, 13, 25, 41, 43, DateTimeKind.Utc).AddTicks(7101), new DateTime(2026, 1, 9, 13, 25, 41, 43, DateTimeKind.Utc).AddTicks(7102), 10, 2025, "Seed", 1 },
                    { 3, "Seed User", "AMEX", "Seed", new DateTime(2026, 1, 9, 13, 25, 41, 43, DateTimeKind.Utc).AddTicks(7107), new DateTime(2026, 1, 9, 13, 25, 41, 43, DateTimeKind.Utc).AddTicks(7108), 6, 2027, "Seed", 1 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethod_User_UserId",
                table: "PaymentMethod",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethod_User_UserId",
                table: "PaymentMethod");

            migrationBuilder.DeleteData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "CardType",
                table: "PaymentMethod",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CardHolderName",
                table: "PaymentMethod",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethod_User_UserId",
                table: "PaymentMethod",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
