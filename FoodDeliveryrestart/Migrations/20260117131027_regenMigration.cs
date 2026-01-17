using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodDeliveryrestart.Migrations
{
    /// <inheritdoc />
    public partial class regenMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mall",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MallName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mall", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Restaurant",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CuisineType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OperatingHours = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LocationWithinMall = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BusyLevel = table.Column<int>(type: "int", nullable: false),
                    MallId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurant", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Restaurant_Mall_MallId",
                        column: x => x.MallId,
                        principalTable: "Mall",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Block = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Address_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GroupOrder",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClosedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MallId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupOrder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupOrder_Mall_MallId",
                        column: x => x.MallId,
                        principalTable: "Mall",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupOrder_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethod",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ExpiryMonth = table.Column<int>(type: "int", nullable: false),
                    ExpiryYear = table.Column<int>(type: "int", nullable: false),
                    CardHolderName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethod", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentMethod_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenuItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Calories = table.Column<int>(type: "int", nullable: false),
                    CarbohydratesG = table.Column<int>(type: "int", nullable: false),
                    ProteinG = table.Column<int>(type: "int", nullable: false),
                    FatG = table.Column<int>(type: "int", nullable: false),
                    Allergens = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsHalal = table.Column<bool>(type: "bit", nullable: false),
                    IsVegan = table.Column<bool>(type: "bit", nullable: false),
                    IsNutFree = table.Column<bool>(type: "bit", nullable: false),
                    IsDairyFree = table.Column<bool>(type: "bit", nullable: false),
                    RestaurantId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenuItem_Restaurant_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GroupOrderMember",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JoinTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GroupOrderId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupOrderMember", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupOrderMember_GroupOrder_GroupOrderId",
                        column: x => x.GroupOrderId,
                        principalTable: "GroupOrder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupOrderMember_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    GroupOrderId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_GroupOrder_GroupOrderId",
                        column: x => x.GroupOrderId,
                        principalTable: "GroupOrder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ItemPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Subtotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    MenuItemId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItem_MenuItem_MenuItemId",
                        column: x => x.MenuItemId,
                        principalTable: "MenuItem",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderItem_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    PaymentMethodId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payment_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payment_PaymentMethod_PaymentMethodId",
                        column: x => x.PaymentMethodId,
                        principalTable: "PaymentMethod",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "7a0e0dc2-0c6b-4147-b542-10910844be54", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEEdqYFc8P4R5pkL8EHnnG0a5tV8tIMstfldQUFYrQWYP9Nd+f8PzObDMXDI5xoGuOQ==", null, false, "98b4ffb2-a8b4-4efe-a8e6-9e263abb8830", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Mall",
                columns: new[] { "Id", "Address", "CreatedBy", "DateCreated", "DateUpdated", "MallName", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "4 Tampines Central 5, Singapore 529510", "System", new DateTime(2026, 1, 17, 21, 10, 26, 889, DateTimeKind.Local).AddTicks(4762), new DateTime(2026, 1, 17, 21, 10, 26, 889, DateTimeKind.Local).AddTicks(4777), "Tampines Mall", "System" },
                    { 2, "1 HarbourFront Walk, Singapore 098585", "System", new DateTime(2026, 1, 17, 21, 10, 26, 889, DateTimeKind.Local).AddTicks(4778), new DateTime(2026, 1, 17, 21, 10, 26, 889, DateTimeKind.Local).AddTicks(4779), "Vivo City", "System" },
                    { 3, "181 Orchard Rd, Singapore 238896", "System", new DateTime(2026, 1, 17, 21, 10, 26, 889, DateTimeKind.Local).AddTicks(4780), new DateTime(2026, 1, 17, 21, 10, 26, 889, DateTimeKind.Local).AddTicks(4781), "Orchard Central", "System" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Email", "Name", "Password", "PhoneNumber", "UpdatedBy" },
                values: new object[] { 1, "System", new DateTime(2026, 1, 17, 13, 10, 26, 889, DateTimeKind.Utc).AddTicks(3319), new DateTime(2026, 1, 17, 13, 10, 26, 889, DateTimeKind.Utc).AddTicks(3327), "system@local", "System", "changeme", null, "System" });

            migrationBuilder.InsertData(
                table: "PaymentMethod",
                columns: new[] { "Id", "CardHolderName", "CardType", "CreatedBy", "DateCreated", "DateUpdated", "ExpiryMonth", "ExpiryYear", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { 1, "Seed User", "Visa", "System", new DateTime(2026, 1, 17, 13, 10, 26, 889, DateTimeKind.Utc).AddTicks(4566), new DateTime(2026, 1, 17, 13, 10, 26, 889, DateTimeKind.Utc).AddTicks(4567), 12, 2026, "System", 1 },
                    { 2, "Seed User", "MasterCard", "System", new DateTime(2026, 1, 17, 13, 10, 26, 889, DateTimeKind.Utc).AddTicks(4574), new DateTime(2026, 1, 17, 13, 10, 26, 889, DateTimeKind.Utc).AddTicks(4575), 10, 2025, "System", 1 },
                    { 3, "Seed User", "AMEX", "System", new DateTime(2026, 1, 17, 13, 10, 26, 889, DateTimeKind.Utc).AddTicks(4577), new DateTime(2026, 1, 17, 13, 10, 26, 889, DateTimeKind.Utc).AddTicks(4577), 6, 2027, "System", 1 }
                });

            migrationBuilder.InsertData(
                table: "Restaurant",
                columns: new[] { "Id", "BusyLevel", "CreatedBy", "CuisineType", "DateCreated", "DateUpdated", "ImageUrl", "LocationWithinMall", "MallId", "Name", "OperatingHours", "Rating", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, "Seed", "Fast Food", new DateTime(2026, 1, 17, 21, 10, 26, 889, DateTimeKind.Local).AddTicks(4907), new DateTime(2026, 1, 17, 21, 10, 26, 889, DateTimeKind.Local).AddTicks(4907), "https://upload.wikimedia.org/wikipedia/commons/thumb/2/26/All_American_Food_Logo.svg/1024px-All_American_Food_Logo.svg.png", "1-24", 1, "A&W", "10am-10pm", 4.4m, "Seed" },
                    { 2, 2, "Seed", "Western", new DateTime(2026, 1, 17, 21, 10, 26, 889, DateTimeKind.Local).AddTicks(4909), new DateTime(2026, 1, 17, 21, 10, 26, 889, DateTimeKind.Local).AddTicks(4910), "https://images.unsplash.com/photo-1550547660-d9450f859349?auto=format&fit=crop&w=1600&q=70", "1-68", 1, "Burger Lab", "10am-10pm", 4.6m, "Seed" },
                    { 3, 1, "Seed", "Fast Food", new DateTime(2026, 1, 17, 21, 10, 26, 889, DateTimeKind.Local).AddTicks(4912), new DateTime(2026, 1, 17, 21, 10, 26, 889, DateTimeKind.Local).AddTicks(4913), "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e6/Jollibee_Foods_Corporation_logo.png/1024px-Jollibee_Foods_Corporation_logo.png", "8-90", 1, "Jollibee", "10am-10pm", 4.7m, "Seed" },
                    { 4, 2, "Seed", "Fast Food", new DateTime(2026, 1, 17, 21, 10, 26, 889, DateTimeKind.Local).AddTicks(4914), new DateTime(2026, 1, 17, 21, 10, 26, 889, DateTimeKind.Local).AddTicks(4915), "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bf/KFC_logo.svg/1024px-KFC_logo.svg.png", "8-89", 1, "KFC", "24/7", 4.2m, "Seed" },
                    { 5, 2, "Seed", "Fast Food", new DateTime(2026, 1, 17, 21, 10, 26, 889, DateTimeKind.Local).AddTicks(4917), new DateTime(2026, 1, 17, 21, 10, 26, 889, DateTimeKind.Local).AddTicks(4917), "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4b/McDonald%27s_logo.svg/1024px-McDonald%27s_logo.svg.png", "8-88", 1, "McDonald's", "24/7", 4.3m, "Seed" },
                    { 6, 0, "Seed", "Western", new DateTime(2026, 1, 17, 21, 10, 26, 889, DateTimeKind.Local).AddTicks(4919), new DateTime(2026, 1, 17, 21, 10, 26, 889, DateTimeKind.Local).AddTicks(4920), "https://images.unsplash.com/photo-1521389508051-d7ffb5dc8f6f?auto=format&fit=crop&w=1600&q=70", "1-67", 1, "Pasta Corner", "24/7", 4.1m, "Seed" },
                    { 7, 1, "Seed", "Western Food", new DateTime(2026, 1, 17, 21, 10, 26, 889, DateTimeKind.Local).AddTicks(4921), new DateTime(2026, 1, 17, 21, 10, 26, 889, DateTimeKind.Local).AddTicks(4922), "https://images.unsplash.com/photo-1548365328-8b849e6a1e05?auto=format&fit=crop&w=1600&q=70", "1-66", 1, "Pizza House", "24/7", 4.5m, "Seed" },
                    { 8, 1, "Seed", "Thai Food", new DateTime(2026, 1, 17, 21, 10, 26, 889, DateTimeKind.Local).AddTicks(4924), new DateTime(2026, 1, 17, 21, 10, 26, 889, DateTimeKind.Local).AddTicks(4924), "https://images.unsplash.com/photo-1559847844-5315695dadae?auto=format&fit=crop&w=1600&q=70", "1-25", 1, "Sanook Kitchen", "10am-10pm", 4.6m, "Seed" },
                    { 9, 0, "Seed", "Dessert", new DateTime(2026, 1, 17, 21, 10, 26, 889, DateTimeKind.Local).AddTicks(4926), new DateTime(2026, 1, 17, 21, 10, 26, 889, DateTimeKind.Local).AddTicks(4926), "https://images.unsplash.com/photo-1551024601-bec78aea704b?auto=format&fit=crop&w=1600&q=70", "1-23", 1, "Yochi", "10am-10pm", 4.8m, "Seed" }
                });

            migrationBuilder.InsertData(
                table: "MenuItem",
                columns: new[] { "Id", "Allergens", "Calories", "CarbohydratesG", "CreatedBy", "DateCreated", "DateUpdated", "Description", "FatG", "ImageUrl", "IsDairyFree", "IsHalal", "IsNutFree", "IsVegan", "ItemName", "Price", "ProteinG", "RestaurantId", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Milk, Wheat", 650, 45, "Seed", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Signature burger topped with mozzarella and onions.", 40, "https://images.unsplash.com/photo-1550547660-d9450f859349?auto=format&fit=crop&w=1200&q=80", false, true, true, false, "Mozza Burger", 9.40m, 30, 1, "Seed" },
                    { 2, "Wheat", 420, 30, "Seed", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Hot dog topped with savory coney sauce.", 25, "https://images.unsplash.com/photo-1613482084286-41f25b486fa2?auto=format&fit=crop&w=1200&q=80", true, true, true, false, "Coney Dog", 6.60m, 15, 1, "Seed" },
                    { 3, "", 360, 48, "Seed", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Crispy curly fries, perfect for sharing.", 16, "https://images.unsplash.com/photo-1541592106381-b31e9677c0e5?auto=format&fit=crop&w=1200&q=80", true, true, true, true, "Curly Fries", 3.60m, 4, 1, "Seed" },
                    { 4, "Milk", 380, 52, "Seed", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Classic root beer with vanilla ice cream.", 12, "https://images.unsplash.com/photo-1513558161293-cdaf765ed2fd?auto=format&fit=crop&w=1200&q=80", false, true, true, false, "Root Beer Float", 3.50m, 6, 1, "Seed" },
                    { 5, "Wheat, Egg", 750, 50, "Seed", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Juicy beef patty with house sauce and fresh veg.", 45, "https://images.unsplash.com/photo-1568901346375-23c9450c58cd?auto=format&fit=crop&w=1200&q=80", true, true, true, false, "Basic Burger", 20.50m, 40, 2, "Seed" },
                    { 6, "Fish, Wheat, Egg", 620, 48, "Seed", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Crispy fish fillet with tartar sauce.", 30, "https://images.unsplash.com/photo-1550317138-10000687a72b?auto=format&fit=crop&w=1200&q=80", true, true, true, false, "Fish Burger", 17.80m, 30, 2, "Seed" },
                    { 7, "Wheat", 410, 46, "Seed", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Golden battered onion rings.", 20, "https://images.unsplash.com/photo-1639024471283-03518883512d?auto=format&fit=crop&w=1200&q=80", true, true, true, true, "Onion Rings", 6.80m, 4, 2, "Seed" },
                    { 8, "", 520, 55, "Seed", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Fries tossed with truffle oil and seasoning.", 28, "https://images.unsplash.com/photo-1573080496219-bb080dd4f877?auto=format&fit=crop&w=1200&q=80", true, true, true, true, "Truffle Fries", 8.00m, 6, 2, "Seed" },
                    { 9, "Wheat", 480, 10, "Seed", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Crispy fried chicken with gravy.", 30, "https://images.unsplash.com/photo-1626082927389-6cd097cdc6ec?auto=format&fit=crop&w=1200&q=80", true, true, true, false, "Chickenjoy (1pc)", 5.70m, 28, 3, "Seed" },
                    { 10, "Wheat", 560, 80, "Seed", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sweet-style spaghetti with hotdog slices.", 16, "https://images.unsplash.com/photo-1621996346565-e3dbc646d9a9?auto=format&fit=crop&w=1200&q=80", true, true, true, false, "Jolly Spaghetti", 6.50m, 18, 3, "Seed" },
                    { 11, "Wheat, Egg", 390, 35, "Seed", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Classic burger with Jollibee signature dressing.", 20, "https://images.unsplash.com/photo-1551782450-a2132b4ba21d?auto=format&fit=crop&w=1200&q=80", true, true, true, false, "Yumburger", 3.90m, 18, 3, "Seed" },
                    { 12, "Wheat", 260, 34, "Seed", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Crispy pie filled with peach-mango goodness.", 12, "https://images.unsplash.com/photo-1614373532018-92a74d68dfc3?auto=format&fit=crop&w=1200&q=80", true, true, true, true, "Peach Mango Pie", 1.90m, 2, 3, "Seed" },
                    { 13, "Wheat", 320, 5, "Seed", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "KFC signature chicken with 11 herbs & spices.", 22, "https://images.unsplash.com/photo-1626082927389-6cd097cdc6ec?auto=format&fit=crop&w=1200&q=80", true, true, true, false, "Original Recipe Chicken (1pc)", 4.45m, 24, 4, "Seed" },
                    { 14, "Wheat, Egg, Milk", 550, 40, "Seed", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Spicy chicken fillet burger with mayo.", 30, "https://images.unsplash.com/photo-1606755962773-d324e0a13086?auto=format&fit=crop&w=1200&q=80", false, true, true, false, "Zinger Burger", 7.50m, 28, 4, "Seed" },
                    { 15, "Milk", 460, 50, "Seed", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Fries topped with warm cheese sauce.", 22, "https://images.unsplash.com/photo-1586190848861-99aa4a171e90?auto=format&fit=crop&w=1200&q=80", false, true, true, false, "Cheese Fries", 4.50m, 8, 4, "Seed" },
                    { 16, "Wheat", 430, 18, "Seed", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Bite-sized chicken chunks, crispy and juicy.", 28, "https://images.unsplash.com/photo-1604908176997-125f25cc500f?auto=format&fit=crop&w=1200&q=80", true, true, true, false, "Popcorn Chicken", 5.50m, 26, 4, "Seed" },
                    { 17, "Wheat, Egg, Milk", 540, 47, "Seed", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Two beef patties with special sauce and lettuce.", 29, "https://images.unsplash.com/photo-1550547660-d9450f859349?auto=format&fit=crop&w=1200&q=80", false, true, true, false, "Big Mac", 7.60m, 25, 5, "Seed" },
                    { 18, "Wheat, Egg", 560, 44, "Seed", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Spicy chicken burger with lettuce and mayo.", 28, "https://images.unsplash.com/photo-1606755962773-d324e0a13086?auto=format&fit=crop&w=1200&q=80", true, true, true, false, "McSpicy", 7.50m, 30, 5, "Seed" },
                    { 19, "Fish, Wheat, Milk", 390, 38, "Seed", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Fish patty with tartar sauce and cheese.", 18, "https://images.unsplash.com/photo-1550317138-10000687a72b?auto=format&fit=crop&w=1200&q=80", false, true, true, false, "Filet-O-Fish", 7.45m, 14, 5, "Seed" },
                    { 20, "Wheat", 240, 34, "Seed", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Crispy pastry filled with warm apple cinnamon.", 10, "https://images.unsplash.com/photo-1519869325930-281384150729?auto=format&fit=crop&w=1200&q=80", true, true, true, true, "Apple Pie", 2.50m, 2, 5, "Seed" },
                    { 21, "Wheat, Milk, Egg", 720, 75, "Seed", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Creamy pasta with bacon and parmesan.", 36, "https://images.unsplash.com/photo-1608756687911-aa1599ab3bd9?auto=format&fit=crop&w=1200&q=80", false, true, true, false, "Carbonara", 14.90m, 28, 6, "Seed" },
                    { 22, "Wheat", 620, 70, "Seed", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Garlic, olive oil, chili flakes, and parsley.", 28, "https://images.unsplash.com/photo-1523986371872-9d3ba2e2f642?auto=format&fit=crop&w=1200&q=80", true, true, true, true, "Aglio Olio", 12.90m, 14, 6, "Seed" },
                    { 23, "Wheat", 740, 78, "Seed", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Slow-cooked beef ragu with pasta.", 34, "https://images.unsplash.com/photo-1604908812488-5f5f7e62a3b4?auto=format&fit=crop&w=1200&q=80", true, true, true, false, "Beef Bolognese", 16.90m, 32, 6, "Seed" },
                    { 24, "Wheat, Milk", 850, 80, "Seed", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Layered pasta baked with meat sauce and cheese.", 46, "https://images.unsplash.com/photo-1604908177453-7462950a6a32?auto=format&fit=crop&w=1200&q=80", false, true, true, false, "Lasagna", 18.90m, 36, 6, "Seed" },
                    { 25, "Wheat, Milk", 780, 90, "Seed", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Tomato sauce, mozzarella, basil.", 32, "https://images.unsplash.com/photo-1548365328-8b849e6a1e05?auto=format&fit=crop&w=1200&q=80", false, true, true, false, "Margherita Pizza", 12.90m, 28, 7, "Seed" },
                    { 26, "Wheat, Milk", 920, 95, "Seed", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Pepperoni, mozzarella, tomato base.", 48, "https://images.unsplash.com/photo-1601924638867-3ec9c6f3a3c1?auto=format&fit=crop&w=1200&q=80", false, true, true, false, "Pepperoni Pizza", 14.90m, 36, 7, "Seed" },
                    { 27, "Wheat, Milk", 880, 92, "Seed", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ham and pineapple with mozzarella.", 44, "https://images.unsplash.com/photo-1594007654729-407eedc4be65?auto=format&fit=crop&w=1200&q=80", false, true, true, false, "Hawaiian Pizza", 14.50m, 34, 7, "Seed" },
                    { 28, "Wheat, Milk", 420, 48, "Seed", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Toasted garlic bread slices.", 18, "https://images.unsplash.com/photo-1608198093002-ad4e005484ec?auto=format&fit=crop&w=1200&q=80", false, true, true, false, "Garlic Bread", 5.50m, 8, 7, "Seed" },
                    { 29, "Shellfish", 680, 85, "Seed", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Thai-style fried rice with prawn and pineapple.", 20, "https://images.unsplash.com/photo-1604909053191-8f3f0f6b1cf5?auto=format&fit=crop&w=1200&q=80", true, true, true, false, "Pineapple Fried Rice (Prawn)", 9.48m, 18, 8, "Seed" },
                    { 30, "Shellfish, Fish", 420, 18, "Seed", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Creamy tom yum with seafood and herbs.", 22, "https://images.unsplash.com/photo-1548940740-204726a19be3?auto=format&fit=crop&w=1200&q=80", false, true, true, false, "Creamy Tom Yum Soup (Seafood)", 12.90m, 20, 8, "Seed" },
                    { 31, "Shellfish, Peanuts", 700, 88, "Seed", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Stir-fried Thai noodles with prawn.", 24, "https://images.unsplash.com/photo-1559314809-0b9c35b2f5f5?auto=format&fit=crop&w=1200&q=80", true, true, false, false, "Pad Thai (Prawn)", 10.90m, 20, 8, "Seed" },
                    { 32, "", 640, 80, "Seed", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Basil chicken served with fragrant rice.", 18, "https://images.unsplash.com/photo-1540189549336-e6e99c3679fe?auto=format&fit=crop&w=1200&q=80", true, true, true, false, "Thai Basil Chicken Rice", 9.40m, 22, 8, "Seed" },
                    { 33, "Milk", 280, 40, "Seed", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Classic tart froyo cup (choose toppings).", 8, "https://images.unsplash.com/photo-1541976844346-f18aeac57b06?auto=format&fit=crop&w=1200&q=80", false, true, true, false, "Signature Tart Frozen Yogurt Cup", 7.90m, 4, 9, "Seed" },
                    { 34, "Milk, Wheat", 320, 44, "Seed", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Creamy froyo with cookies flavour.", 10, "https://images.unsplash.com/photo-1563805042-7684c019e1cb?auto=format&fit=crop&w=1200&q=80", false, true, true, false, "Cookies & Cream Frozen Yogurt Cup", 8.50m, 5, 9, "Seed" },
                    { 35, "Soy", 90, 10, "Seed", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Add Biscoff spread as topping.", 5, "https://images.unsplash.com/photo-1519681393784-d120267933ba?auto=format&fit=crop&w=1200&q=80", true, true, true, true, "Biscoff Spread Topping", 1.50m, 0, 9, "Seed" },
                    { 36, "Wheat, Milk, Egg", 140, 18, "Seed", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Add chocolate brownie as topping.", 7, "https://images.unsplash.com/photo-1606313564200-e75d5e30476c?auto=format&fit=crop&w=1200&q=80", false, true, true, false, "Chocolate Fudge Brownie Topping", 1.80m, 2, 9, "Seed" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_UserId",
                table: "Address",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_GroupOrder_MallId",
                table: "GroupOrder",
                column: "MallId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupOrder_UserId",
                table: "GroupOrder",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupOrderMember_GroupOrderId",
                table: "GroupOrderMember",
                column: "GroupOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupOrderMember_UserId",
                table: "GroupOrderMember",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItem_RestaurantId",
                table: "MenuItem",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_GroupOrderId",
                table: "Order",
                column: "GroupOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserId",
                table: "Order",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_MenuItemId",
                table: "OrderItem",
                column: "MenuItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItem",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_OrderId",
                table: "Payment",
                column: "OrderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Payment_PaymentMethodId",
                table: "Payment",
                column: "PaymentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethod_UserId",
                table: "PaymentMethod",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurant_MallId",
                table: "Restaurant",
                column: "MallId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "GroupOrderMember");

            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "MenuItem");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "PaymentMethod");

            migrationBuilder.DropTable(
                name: "Restaurant");

            migrationBuilder.DropTable(
                name: "GroupOrder");

            migrationBuilder.DropTable(
                name: "Mall");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
