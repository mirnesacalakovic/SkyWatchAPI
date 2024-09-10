using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SkyWatch_API.Migrations
{
    /// <inheritdoc />
    public partial class alarmCorrections : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alarm_AspNetUsers_UserId",
                table: "Alarm");

            migrationBuilder.DropForeignKey(
                name: "FK_Alarm_WeatherCondition_ConditionsId",
                table: "Alarm");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Alarm",
                table: "Alarm");

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

            migrationBuilder.RenameTable(
                name: "Alarm",
                newName: "Alarms");

            migrationBuilder.RenameIndex(
                name: "IX_Alarm_UserId",
                table: "Alarms",
                newName: "IX_Alarms_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Alarm_ConditionsId",
                table: "Alarms",
                newName: "IX_Alarms_ConditionsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Alarms",
                table: "Alarms",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0b7f3890-f624-4d10-850b-16dfe93cc444", null, "Member", "MEMBER" },
                    { "b2eedbd7-0662-42ec-89d0-25bc35fca3b4", null, "Admin", "ADMIN" },
                    { "fece52bb-22a0-40d5-9b79-01eeb12ca0a5", null, "Tech", "TECH" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Alarms_AspNetUsers_UserId",
                table: "Alarms",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Alarms_WeatherCondition_ConditionsId",
                table: "Alarms",
                column: "ConditionsId",
                principalTable: "WeatherCondition",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alarms_AspNetUsers_UserId",
                table: "Alarms");

            migrationBuilder.DropForeignKey(
                name: "FK_Alarms_WeatherCondition_ConditionsId",
                table: "Alarms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Alarms",
                table: "Alarms");

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

            migrationBuilder.RenameTable(
                name: "Alarms",
                newName: "Alarm");

            migrationBuilder.RenameIndex(
                name: "IX_Alarms_UserId",
                table: "Alarm",
                newName: "IX_Alarm_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Alarms_ConditionsId",
                table: "Alarm",
                newName: "IX_Alarm_ConditionsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Alarm",
                table: "Alarm",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b07172d0-7293-4ee9-b099-bd12be4eb589", null, "Tech", "TECH" },
                    { "cde975da-404d-4161-a86f-2d1e5c61456c", null, "Member", "MEMBER" },
                    { "f4b9d76c-27d1-4b26-a91a-be37c6d5fbb3", null, "Admin", "ADMIN" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Alarm_AspNetUsers_UserId",
                table: "Alarm",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Alarm_WeatherCondition_ConditionsId",
                table: "Alarm",
                column: "ConditionsId",
                principalTable: "WeatherCondition",
                principalColumn: "Id");
        }
    }
}
