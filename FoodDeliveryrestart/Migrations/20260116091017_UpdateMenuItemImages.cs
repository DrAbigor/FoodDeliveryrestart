using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodDeliveryrestart.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMenuItemImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1a2b3c4-d5e6-4789-8901-234567890abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "279d5833-2ef8-48b3-bd7e-e6dd78843fb4", "AQAAAAIAAYagAAAAENDAPDXgFeNcgw5a+1bprV+r0eCXDcAQnktBOBGy0+lpeUebmN1XRYCttD2gyCPnXA==", "e5a59650-ff65-43ea-bde2-9d7c4b3d9e36" });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 17, 10, 16, 952, DateTimeKind.Local).AddTicks(9507), new DateTime(2026, 1, 16, 17, 10, 16, 952, DateTimeKind.Local).AddTicks(9517) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 17, 10, 16, 952, DateTimeKind.Local).AddTicks(9519), new DateTime(2026, 1, 16, 17, 10, 16, 952, DateTimeKind.Local).AddTicks(9519) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 17, 10, 16, 952, DateTimeKind.Local).AddTicks(9520), new DateTime(2026, 1, 16, 17, 10, 16, 952, DateTimeKind.Local).AddTicks(9521) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1550547660-d9450f859349?auto=format&fit=crop&w=600&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1613482084286-41f25b486fa2?auto=format&fit=crop&w=600&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1541592106381-b31e9677c0e5?auto=format&fit=crop&w=600&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1541976844346-f18aeac57b06?auto=format&fit=crop&w=600&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1568901346375-23c9450c58cd?auto=format&fit=crop&w=600&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1550317138-10000687a72b?auto=format&fit=crop&w=600&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1639024471283-03518883512d?auto=format&fit=crop&w=600&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1541592106381-b31e9677c0e5?auto=format&fit=crop&w=600&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1626082927389-6cd097cdc6ec?auto=format&fit=crop&w=600&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1621996346565-e3dbc646d9a9?auto=format&fit=crop&w=600&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1568901346375-23c9450c58cd?auto=format&fit=crop&w=600&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1568571780765-9276ac8b75a1?auto=format&fit=crop&w=600&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1626082927389-6cd097cdc6ec?auto=format&fit=crop&w=600&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1606755962773-d324e0a13086?auto=format&fit=crop&w=600&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1541592106381-b31e9677c0e5?auto=format&fit=crop&w=600&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1604908176997-125f25cc500f?auto=format&fit=crop&w=600&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1550547660-d9450f859349?auto=format&fit=crop&w=600&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1606755962773-d324e0a13086?auto=format&fit=crop&w=600&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1550317138-10000687a72b?auto=format&fit=crop&w=600&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1519869325930-281384150729?auto=format&fit=crop&w=600&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1608756687911-aa1599ab3bd9?auto=format&fit=crop&w=600&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 22,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1523986371872-9d3ba2e2f642?auto=format&fit=crop&w=600&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 23,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1604908812488-5f5f7e62a3b4?auto=format&fit=crop&w=600&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 24,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1608756687911-aa1599ab3bd9?auto=format&fit=crop&w=600&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 25,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1548365328-8b849e6a1e05?auto=format&fit=crop&w=600&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 26,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1601924638867-3ec9c6f3a3c1?auto=format&fit=crop&w=600&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 27,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1594007654729-407eedc4be65?auto=format&fit=crop&w=600&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 28,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1604908176997-125f25cc500f?auto=format&fit=crop&w=600&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 29,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1604909053191-8f3f0f6b1cf5?auto=format&fit=crop&w=600&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 30,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1548940740-204726a19be3?auto=format&fit=crop&w=600&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 31,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1559314809-0b9c35b2f5f5?auto=format&fit=crop&w=600&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 32,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1604908176997-125f25cc500f?auto=format&fit=crop&w=600&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 33,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1541976844346-f18aeac57b06?auto=format&fit=crop&w=600&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 34,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1563805042-7684c019e1cb?auto=format&fit=crop&w=600&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 35,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1613482084286-41f25b486fa2?auto=format&fit=crop&w=600&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 36,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1606313564200-e75d5e30476c?auto=format&fit=crop&w=600&q=80");

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 9, 10, 16, 952, DateTimeKind.Utc).AddTicks(9388), new DateTime(2026, 1, 16, 9, 10, 16, 952, DateTimeKind.Utc).AddTicks(9389) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 9, 10, 16, 952, DateTimeKind.Utc).AddTicks(9391), new DateTime(2026, 1, 16, 9, 10, 16, 952, DateTimeKind.Utc).AddTicks(9391) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 9, 10, 16, 952, DateTimeKind.Utc).AddTicks(9393), new DateTime(2026, 1, 16, 9, 10, 16, 952, DateTimeKind.Utc).AddTicks(9393) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 17, 10, 16, 952, DateTimeKind.Local).AddTicks(9625), new DateTime(2026, 1, 16, 17, 10, 16, 952, DateTimeKind.Local).AddTicks(9626) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 17, 10, 16, 952, DateTimeKind.Local).AddTicks(9629), new DateTime(2026, 1, 16, 17, 10, 16, 952, DateTimeKind.Local).AddTicks(9629) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 17, 10, 16, 952, DateTimeKind.Local).AddTicks(9632), new DateTime(2026, 1, 16, 17, 10, 16, 952, DateTimeKind.Local).AddTicks(9632) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 17, 10, 16, 952, DateTimeKind.Local).AddTicks(9634), new DateTime(2026, 1, 16, 17, 10, 16, 952, DateTimeKind.Local).AddTicks(9635) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 17, 10, 16, 952, DateTimeKind.Local).AddTicks(9637), new DateTime(2026, 1, 16, 17, 10, 16, 952, DateTimeKind.Local).AddTicks(9637) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 17, 10, 16, 952, DateTimeKind.Local).AddTicks(9639), new DateTime(2026, 1, 16, 17, 10, 16, 952, DateTimeKind.Local).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 17, 10, 16, 952, DateTimeKind.Local).AddTicks(9642), new DateTime(2026, 1, 16, 17, 10, 16, 952, DateTimeKind.Local).AddTicks(9643) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 17, 10, 16, 952, DateTimeKind.Local).AddTicks(9645), new DateTime(2026, 1, 16, 17, 10, 16, 952, DateTimeKind.Local).AddTicks(9645) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 17, 10, 16, 952, DateTimeKind.Local).AddTicks(9647), new DateTime(2026, 1, 16, 17, 10, 16, 952, DateTimeKind.Local).AddTicks(9648) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 9, 10, 16, 952, DateTimeKind.Utc).AddTicks(8346), new DateTime(2026, 1, 16, 9, 10, 16, 952, DateTimeKind.Utc).AddTicks(8350) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://source.unsplash.com/featured/600x600/?burger,cheese&sig=1");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://source.unsplash.com/featured/600x600/?hotdog&sig=2");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://source.unsplash.com/featured/600x600/?fries&sig=3");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://source.unsplash.com/featured/600x600/?root-beer,float,ice-cream&sig=4");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://source.unsplash.com/featured/600x600/?beef-burger&sig=5");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://source.unsplash.com/featured/600x600/?fish-sandwich&sig=6");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://source.unsplash.com/featured/600x600/?onion-rings&sig=7");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "https://source.unsplash.com/featured/600x600/?truffle,fries&sig=8");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "https://source.unsplash.com/featured/600x600/?fried-chicken&sig=9");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "https://source.unsplash.com/featured/600x600/?spaghetti&sig=10");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "https://source.unsplash.com/featured/600x600/?burger&sig=11");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: "https://source.unsplash.com/featured/600x600/?mango,pie&sig=12");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrl",
                value: "https://source.unsplash.com/featured/600x600/?fried-chicken,crispy&sig=13");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageUrl",
                value: "https://source.unsplash.com/featured/600x600/?chicken-burger,spicy&sig=14");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrl",
                value: "https://source.unsplash.com/featured/600x600/?cheese-fries&sig=15");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageUrl",
                value: "https://source.unsplash.com/featured/600x600/?popcorn-chicken&sig=16");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageUrl",
                value: "https://source.unsplash.com/featured/600x600/?burger,fast-food&sig=17");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImageUrl",
                value: "https://source.unsplash.com/featured/600x600/?spicy,chicken-burger&sig=18");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImageUrl",
                value: "https://source.unsplash.com/featured/600x600/?fish-burger&sig=19");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageUrl",
                value: "https://source.unsplash.com/featured/600x600/?apple-pie&sig=20");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImageUrl",
                value: "https://source.unsplash.com/featured/600x600/?carbonara,pasta&sig=21");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 22,
                column: "ImageUrl",
                value: "https://source.unsplash.com/featured/600x600/?aglio-olio,pasta&sig=22");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 23,
                column: "ImageUrl",
                value: "https://source.unsplash.com/featured/600x600/?bolognese,pasta&sig=23");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 24,
                column: "ImageUrl",
                value: "https://source.unsplash.com/featured/600x600/?lasagna&sig=24");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 25,
                column: "ImageUrl",
                value: "https://source.unsplash.com/featured/600x600/?margherita,pizza&sig=25");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 26,
                column: "ImageUrl",
                value: "https://source.unsplash.com/featured/600x600/?pepperoni,pizza&sig=26");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 27,
                column: "ImageUrl",
                value: "https://source.unsplash.com/featured/600x600/?hawaiian,pizza&sig=27");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 28,
                column: "ImageUrl",
                value: "https://source.unsplash.com/featured/600x600/?garlic-bread&sig=28");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 29,
                column: "ImageUrl",
                value: "https://source.unsplash.com/featured/600x600/?pineapple,fried-rice&sig=29");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 30,
                column: "ImageUrl",
                value: "https://source.unsplash.com/featured/600x600/?tom-yum,soup&sig=30");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 31,
                column: "ImageUrl",
                value: "https://source.unsplash.com/featured/600x600/?pad-thai&sig=31");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 32,
                column: "ImageUrl",
                value: "https://source.unsplash.com/featured/600x600/?thai,basil,chicken,rice&sig=32");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 33,
                column: "ImageUrl",
                value: "https://source.unsplash.com/featured/600x600/?frozen-yogurt&sig=33");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 34,
                column: "ImageUrl",
                value: "https://source.unsplash.com/featured/600x600/?cookies,cream,dessert&sig=34");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 35,
                column: "ImageUrl",
                value: "https://source.unsplash.com/featured/600x600/?biscoff,cookie-butter&sig=35");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 36,
                column: "ImageUrl",
                value: "https://source.unsplash.com/featured/600x600/?brownie,chocolate&sig=36");

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
    }
}
