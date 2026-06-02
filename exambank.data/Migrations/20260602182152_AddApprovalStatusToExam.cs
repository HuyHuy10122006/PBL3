using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace exambank.data.Migrations
{
    /// <inheritdoc />
    public partial class AddApprovalStatusToExam : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AdminNote",
                table: "Exams",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ApprovalStatus",
                table: "Exams",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdminNote",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "ApprovalStatus",
                table: "Exams");
        }
    }
}
