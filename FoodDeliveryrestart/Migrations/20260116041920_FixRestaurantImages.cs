using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodDeliveryrestart.Migrations
{
    /// <inheritdoc />
    public partial class FixRestaurantImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1a2b3c4-d5e6-4789-8901-234567890abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "147f26b2-bd65-4e1b-9f42-0105f6f47f7f", "AQAAAAIAAYagAAAAEI1pft148y/+D0nNEiqZXkre5SYV0JQLcZjMipHdImt1B4hD9qEMWyDwyuJnXI5aAA==", "7b5d1a90-05fa-48ab-9853-8b8f6be53c7f" });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3588), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3595) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3596), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3597) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3598), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3599) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3883), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3884) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3887), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3887) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3890), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3890) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3893), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3894) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3896), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3897) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3899), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3900) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3902), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3903) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3905), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3906) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3908), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3909) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3911), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3912) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3914), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3915) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3918), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3918) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3921), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3921) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3924), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3924) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3927), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3927) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3930), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3930) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3933), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3933) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3936), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3936) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3939), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3939) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3942), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3943) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3945), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3946) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3948), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3949) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3951), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3952) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3954), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3955) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3957), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3958) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3960), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3961) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3964), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3964) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3967), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3967) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3970), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3970) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3973), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3973) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3976), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3976) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3979), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3979) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3982), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3983) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3985), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3986) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3988), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3989) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3991), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3992) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 4, 19, 19, 254, DateTimeKind.Utc).AddTicks(3438), new DateTime(2026, 1, 16, 4, 19, 19, 254, DateTimeKind.Utc).AddTicks(3439) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 4, 19, 19, 254, DateTimeKind.Utc).AddTicks(3440), new DateTime(2026, 1, 16, 4, 19, 19, 254, DateTimeKind.Utc).AddTicks(3441) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 4, 19, 19, 254, DateTimeKind.Utc).AddTicks(3443), new DateTime(2026, 1, 16, 4, 19, 19, 254, DateTimeKind.Utc).AddTicks(3443) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3691), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3692), "https://upload.wikimedia.org/wikipedia/commons/thumb/2/26/All_American_Food_Logo.svg/1024px-All_American_Food_Logo.svg.png" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3694), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3695), "https://images.unsplash.com/photo-1550547660-d9450f859349?auto=format&fit=crop&w=1600&q=70" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3697), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3697), "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e6/Jollibee_Foods_Corporation_logo.png/1024px-Jollibee_Foods_Corporation_logo.png" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3699), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3700), "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bf/KFC_logo.svg/1024px-KFC_logo.svg.png" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3702), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3702), "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4b/McDonald%27s_logo.svg/1024px-McDonald%27s_logo.svg.png" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3704), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3705), "https://images.unsplash.com/photo-1521389508051-d7ffb5dc8f6f?auto=format&fit=crop&w=1600&q=70" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3707), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3707), "https://images.unsplash.com/photo-1548365328-8b849e6a1e05?auto=format&fit=crop&w=1600&q=70" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3709), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3710), "https://images.unsplash.com/photo-1559847844-5315695dadae?auto=format&fit=crop&w=1600&q=70" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3712), new DateTime(2026, 1, 16, 12, 19, 19, 254, DateTimeKind.Local).AddTicks(3713), "https://images.unsplash.com/photo-1551024601-bec78aea704b?auto=format&fit=crop&w=1600&q=70" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 4, 19, 19, 254, DateTimeKind.Utc).AddTicks(2263), new DateTime(2026, 1, 16, 4, 19, 19, 254, DateTimeKind.Utc).AddTicks(2267) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1a2b3c4-d5e6-4789-8901-234567890abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05bc2b01-372b-4f28-acb6-f8a580d8ed45", "AQAAAAIAAYagAAAAEF/0iRalRgywZqg4G3PSwsF8XVSZ20kAl3dfDmKGTmEPPEfjWvLG0KnxG/bucdf5NQ==", "f6d29609-f957-4ebe-b808-17fe83c9bc82" });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(4786), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(4795) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(4796), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(4797) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(4798), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(4799) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5037), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5038) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5040), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5041) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5043), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5044) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5046), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5047) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5049), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5050) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5053), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5053) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5056), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5056) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5059), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5059) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5062), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5062) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5065), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5065) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5068), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5068) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5071), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5071) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5074), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5074) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5077), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5078) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5080), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5081) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5085), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5085) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5088), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5088) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5091), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5091) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5094), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5094) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5097), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5097) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5100), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5100) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5103), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5103) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5106), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5106) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5109), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5109) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5112), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5112) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5115), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5115) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5118), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5118) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5121), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5121) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5124), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5125) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5127), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5128) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5156), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5156) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5159), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5160) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5162), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5163) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5165), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5166) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5168), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5169) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5172), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(5172) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 3, 33, 17, 176, DateTimeKind.Utc).AddTicks(4656), new DateTime(2026, 1, 16, 3, 33, 17, 176, DateTimeKind.Utc).AddTicks(4657) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 3, 33, 17, 176, DateTimeKind.Utc).AddTicks(4659), new DateTime(2026, 1, 16, 3, 33, 17, 176, DateTimeKind.Utc).AddTicks(4659) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 3, 33, 17, 176, DateTimeKind.Utc).AddTicks(4661), new DateTime(2026, 1, 16, 3, 33, 17, 176, DateTimeKind.Utc).AddTicks(4661) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(4900), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(4901), "https://upload.wikimedia.org/wikipedia/commons/6/6f/A%26W_Restaurants_logo.svg" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(4903), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(4903), "https://images.unsplash.com/photo-1550547660-d9450f859349" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(4905), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(4906), "https://upload.wikimedia.org/wikipedia/en/5/5e/Jollibee_Logo.svg" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(4908), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(4909), "https://upload.wikimedia.org/wikipedia/sco/b/bf/KFC_logo.svg" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(4911), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(4911), "https://upload.wikimedia.org/wikipedia/commons/4/4b/McDonald%27s_logo.svg" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(4913), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(4914), "https://images.unsplash.com/photo-1521389508051-d7ffb5dc8f6f" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(4916), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(4916), "https://images.unsplash.com/photo-1548365328-8b849e6a1e05" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(4918), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(4919), "https://images.unsplash.com/photo-1559847844-5315695dadae" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(4921), new DateTime(2026, 1, 16, 11, 33, 17, 176, DateTimeKind.Local).AddTicks(4921), "https://images.unsplash.com/photo-1551024601-bec78aea704b" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 3, 33, 17, 176, DateTimeKind.Utc).AddTicks(3549), new DateTime(2026, 1, 16, 3, 33, 17, 176, DateTimeKind.Utc).AddTicks(3551) });
        }
    }
}
