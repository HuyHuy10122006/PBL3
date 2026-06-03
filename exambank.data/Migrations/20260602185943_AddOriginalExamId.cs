using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace exambank.data.Migrations
{
    /// <inheritdoc />
    public partial class AddOriginalExamId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OriginalExamId",
                table: "Exams",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OriginalExamId",
                table: "Exams");
        }
    }
}
