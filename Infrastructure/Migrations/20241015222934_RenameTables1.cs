using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RenameTables1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "FuelLogs",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AvatarImageUrl",
                table: "AspNetUsers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CustomTag",
                table: "AspNetUsers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "AspNetUsers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_FuelLogs_ApplicationUserId",
                table: "FuelLogs",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_FuelLogs_AspNetUsers_ApplicationUserId",
                table: "FuelLogs",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FuelLogs_AspNetUsers_ApplicationUserId",
                table: "FuelLogs");

            migrationBuilder.DropIndex(
                name: "IX_FuelLogs_ApplicationUserId",
                table: "FuelLogs");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "FuelLogs");

            migrationBuilder.DropColumn(
                name: "AvatarImageUrl",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CustomTag",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "AspNetUsers");
        }
    }
}
