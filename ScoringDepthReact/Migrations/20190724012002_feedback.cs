using Microsoft.EntityFrameworkCore.Migrations;

namespace ScoringDepthReact.Migrations
{
    public partial class feedback : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Feedback",
                newName: "FeedbackId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FeedbackId",
                table: "Feedback",
                newName: "Id");
        }
    }
}
