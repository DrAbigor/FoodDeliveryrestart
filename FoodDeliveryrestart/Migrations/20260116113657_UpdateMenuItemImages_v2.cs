using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodDeliveryrestart.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMenuItemImages_v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1a2b3c4-d5e6-4789-8901-234567890abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e8ef6ef-5c16-4a33-b49b-f0adf546a70a", "AQAAAAIAAYagAAAAEGqVNyxnA3oR1YaZTC/Q+3QrKmNgMwAaGvyqIDlojMKGsbfcPeqK6h1x9Lqr+oLfiA==", "9dfaf4a0-267e-444e-8f1c-947762c94c28" });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 19, 36, 56, 825, DateTimeKind.Local).AddTicks(2132), new DateTime(2026, 1, 16, 19, 36, 56, 825, DateTimeKind.Local).AddTicks(2143) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 19, 36, 56, 825, DateTimeKind.Local).AddTicks(2144), new DateTime(2026, 1, 16, 19, 36, 56, 825, DateTimeKind.Local).AddTicks(2144) });

            migrationBuilder.UpdateData(
                table: "Mall",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 19, 36, 56, 825, DateTimeKind.Local).AddTicks(2146), new DateTime(2026, 1, 16, 19, 36, 56, 825, DateTimeKind.Local).AddTicks(2146) });

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1550547660-d9450f859349?auto=format&fit=crop&w=1200&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1613482084286-41f25b486fa2?auto=format&fit=crop&w=1200&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1541592106381-b31e9677c0e5?auto=format&fit=crop&w=1200&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1513558161293-cdaf765ed2fd?auto=format&fit=crop&w=1200&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1568901346375-23c9450c58cd?auto=format&fit=crop&w=1200&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1550317138-10000687a72b?auto=format&fit=crop&w=1200&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1639024471283-03518883512d?auto=format&fit=crop&w=1200&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1573080496219-bb080dd4f877?auto=format&fit=crop&w=1200&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1626082927389-6cd097cdc6ec?auto=format&fit=crop&w=1200&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1621996346565-e3dbc646d9a9?auto=format&fit=crop&w=1200&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1551782450-a2132b4ba21d?auto=format&fit=crop&w=1200&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1614373532018-92a74d68dfc3?auto=format&fit=crop&w=1200&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1626082927389-6cd097cdc6ec?auto=format&fit=crop&w=1200&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1606755962773-d324e0a13086?auto=format&fit=crop&w=1200&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1586190848861-99aa4a171e90?auto=format&fit=crop&w=1200&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1604908176997-125f25cc500f?auto=format&fit=crop&w=1200&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1550547660-d9450f859349?auto=format&fit=crop&w=1200&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1606755962773-d324e0a13086?auto=format&fit=crop&w=1200&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1550317138-10000687a72b?auto=format&fit=crop&w=1200&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1519869325930-281384150729?auto=format&fit=crop&w=1200&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1608756687911-aa1599ab3bd9?auto=format&fit=crop&w=1200&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 22,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1523986371872-9d3ba2e2f642?auto=format&fit=crop&w=1200&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 23,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1604908812488-5f5f7e62a3b4?auto=format&fit=crop&w=1200&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 24,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1604908177453-7462950a6a32?auto=format&fit=crop&w=1200&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 25,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1548365328-8b849e6a1e05?auto=format&fit=crop&w=1200&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 26,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1601924638867-3ec9c6f3a3c1?auto=format&fit=crop&w=1200&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 27,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1594007654729-407eedc4be65?auto=format&fit=crop&w=1200&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 28,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1608198093002-ad4e005484ec?auto=format&fit=crop&w=1200&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 29,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1604909053191-8f3f0f6b1cf5?auto=format&fit=crop&w=1200&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 30,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1548940740-204726a19be3?auto=format&fit=crop&w=1200&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 31,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1559314809-0b9c35b2f5f5?auto=format&fit=crop&w=1200&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 32,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1540189549336-e6e99c3679fe?auto=format&fit=crop&w=1200&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 33,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1541976844346-f18aeac57b06?auto=format&fit=crop&w=1200&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 34,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1563805042-7684c019e1cb?auto=format&fit=crop&w=1200&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 35,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1519681393784-d120267933ba?auto=format&fit=crop&w=1200&q=80");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 36,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1606313564200-e75d5e30476c?auto=format&fit=crop&w=1200&q=80");

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 36, 56, 825, DateTimeKind.Utc).AddTicks(2006), new DateTime(2026, 1, 16, 11, 36, 56, 825, DateTimeKind.Utc).AddTicks(2006) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 36, 56, 825, DateTimeKind.Utc).AddTicks(2008), new DateTime(2026, 1, 16, 11, 36, 56, 825, DateTimeKind.Utc).AddTicks(2009) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 36, 56, 825, DateTimeKind.Utc).AddTicks(2010), new DateTime(2026, 1, 16, 11, 36, 56, 825, DateTimeKind.Utc).AddTicks(2011) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 19, 36, 56, 825, DateTimeKind.Local).AddTicks(2248), new DateTime(2026, 1, 16, 19, 36, 56, 825, DateTimeKind.Local).AddTicks(2248) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 19, 36, 56, 825, DateTimeKind.Local).AddTicks(2251), new DateTime(2026, 1, 16, 19, 36, 56, 825, DateTimeKind.Local).AddTicks(2252) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 19, 36, 56, 825, DateTimeKind.Local).AddTicks(2254), new DateTime(2026, 1, 16, 19, 36, 56, 825, DateTimeKind.Local).AddTicks(2254) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 19, 36, 56, 825, DateTimeKind.Local).AddTicks(2256), new DateTime(2026, 1, 16, 19, 36, 56, 825, DateTimeKind.Local).AddTicks(2257) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 19, 36, 56, 825, DateTimeKind.Local).AddTicks(2259), new DateTime(2026, 1, 16, 19, 36, 56, 825, DateTimeKind.Local).AddTicks(2259) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 19, 36, 56, 825, DateTimeKind.Local).AddTicks(2261), new DateTime(2026, 1, 16, 19, 36, 56, 825, DateTimeKind.Local).AddTicks(2262) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 19, 36, 56, 825, DateTimeKind.Local).AddTicks(2264), new DateTime(2026, 1, 16, 19, 36, 56, 825, DateTimeKind.Local).AddTicks(2264) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 19, 36, 56, 825, DateTimeKind.Local).AddTicks(2266), new DateTime(2026, 1, 16, 19, 36, 56, 825, DateTimeKind.Local).AddTicks(2267) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 19, 36, 56, 825, DateTimeKind.Local).AddTicks(2269), new DateTime(2026, 1, 16, 19, 36, 56, 825, DateTimeKind.Local).AddTicks(2269) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 36, 56, 825, DateTimeKind.Utc).AddTicks(1037), new DateTime(2026, 1, 16, 11, 36, 56, 825, DateTimeKind.Utc).AddTicks(1041) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
