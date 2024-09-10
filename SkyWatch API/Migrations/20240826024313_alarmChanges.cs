using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SkyWatch_API.Migrations
{
    /// <inheritdoc />
    public partial class alarmChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b7f3890-f624-4d10-850b-16dfe93cc444");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2eedbd7-0662-42ec-89d0-25bc35fca3b4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fece52bb-22a0-40d5-9b79-01eeb12ca0a5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "14092e67-fa06-4a7d-be17-3466ef7a3111", null, "Admin", "ADMIN" },
                    { "6d9df760-5281-4ddb-937b-9a9191439a07", null, "Member", "MEMBER" },
                    { "7a10bf38-c671-403f-aa78-c74e9818d726", null, "Tech", "TECH" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "14092e67-fa06-4a7d-be17-3466ef7a3111");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6d9df760-5281-4ddb-937b-9a9191439a07");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a10bf38-c671-403f-aa78-c74e9818d726");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0b7f3890-f624-4d10-850b-16dfe93cc444", null, "Member", "MEMBER" },
                    { "b2eedbd7-0662-42ec-89d0-25bc35fca3b4", null, "Admin", "ADMIN" },
                    { "fece52bb-22a0-40d5-9b79-01eeb12ca0a5", null, "Tech", "TECH" }
                });
        }
    }
}
