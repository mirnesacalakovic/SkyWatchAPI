using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SkyWatch_API.Migrations
{
    /// <inheritdoc />
    public partial class check : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a68dabef-19c8-4d73-a281-e013087adf47");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd64678d-65a6-4540-82d8-07c43070b6e8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6d6d9e4-8f3d-492a-9bcc-abb85e2564bd");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1a25a82e-0f60-49aa-bfff-9d7ad496837e", null, "Admin", "ADMIN" },
                    { "4906c509-0c9b-4c2e-8264-2b3d01677d20", null, "Tech", "TECH" },
                    { "90b42ccc-9ca1-403f-ab34-d7f4d9769243", null, "Member", "MEMBER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a25a82e-0f60-49aa-bfff-9d7ad496837e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4906c509-0c9b-4c2e-8264-2b3d01677d20");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "90b42ccc-9ca1-403f-ab34-d7f4d9769243");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a68dabef-19c8-4d73-a281-e013087adf47", null, "Member", "MEMBER" },
                    { "cd64678d-65a6-4540-82d8-07c43070b6e8", null, "Tech", "TECH" },
                    { "f6d6d9e4-8f3d-492a-9bcc-abb85e2564bd", null, "Admin", "ADMIN" }
                });
        }
    }
}
