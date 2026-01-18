using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodDeliveryrestart.Migrations
{
    /// <inheritdoc />
    public partial class Baseline_ExistingDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // BASELINE migration:
            // Intentionally empty so EF only records this migration in __EFMigrationsHistory.
            // Your database already has the tables (AspNetRoles, AspNetUsers, etc.),
            // so we must NOT create them again.
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Intentionally empty.
        }
    }
}
