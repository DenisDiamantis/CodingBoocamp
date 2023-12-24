using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IdentityFramework.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "211a83c3-68b4-4e46-bdd5-50703e567893", null, "admin", "admin" },
                    { "78c9a0dc-aae3-4364-a4fa-ab04f961fef3", null, "seller", "seller" },
                    { "c348d211-a860-4e3b-824d-095f9b3a9c60", null, "client", "client" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "211a83c3-68b4-4e46-bdd5-50703e567893");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78c9a0dc-aae3-4364-a4fa-ab04f961fef3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c348d211-a860-4e3b-824d-095f9b3a9c60");
        }
    }
}
