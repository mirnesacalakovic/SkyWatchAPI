using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SkyWatch_API.Migrations
{
    /// <inheritdoc />
    public partial class alarms : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "WeatherCondition",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Precip = table.Column<int>(type: "INTEGER", nullable: false),
                    Cloudcover = table.Column<int>(type: "INTEGER", nullable: false),
                    Temp = table.Column<int>(type: "INTEGER", nullable: false),
                    UvIndex = table.Column<int>(type: "INTEGER", nullable: false),
                    Snow = table.Column<int>(type: "INTEGER", nullable: false),
                    Windspeed = table.Column<int>(type: "INTEGER", nullable: false),
                    Windgust = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherCondition", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Alarm",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Type = table.Column<string>(type: "TEXT", nullable: true),
                    ConditionsId = table.Column<int>(type: "INTEGER", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alarm", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alarm_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Alarm_WeatherCondition_ConditionsId",
                        column: x => x.ConditionsId,
                        principalTable: "WeatherCondition",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b07172d0-7293-4ee9-b099-bd12be4eb589", null, "Tech", "TECH" },
                    { "cde975da-404d-4161-a86f-2d1e5c61456c", null, "Member", "MEMBER" },
                    { "f4b9d76c-27d1-4b26-a91a-be37c6d5fbb3", null, "Admin", "ADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alarm_ConditionsId",
                table: "Alarm",
                column: "ConditionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Alarm_UserId",
                table: "Alarm",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alarm");

            migrationBuilder.DropTable(
                name: "WeatherCondition");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b07172d0-7293-4ee9-b099-bd12be4eb589");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cde975da-404d-4161-a86f-2d1e5c61456c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4b9d76c-27d1-4b26-a91a-be37c6d5fbb3");

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
    }
}
