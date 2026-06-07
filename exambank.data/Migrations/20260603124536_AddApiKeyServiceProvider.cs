using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace exambank.data.Migrations
{
    /// <inheritdoc />
    public partial class AddApiKeyServiceProvider : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApiKey",
                table: "AI_Configs",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ServiceProvider",
                table: "AI_Configs",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApiKey",
                table: "AI_Configs");

            migrationBuilder.DropColumn(
                name: "ServiceProvider",
                table: "AI_Configs");
        }
    }
}
