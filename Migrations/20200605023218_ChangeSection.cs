using Microsoft.EntityFrameworkCore.Migrations;

namespace ThanksCardAPI.Migrations
{
    public partial class ChangeSection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "Sections");

            migrationBuilder.AddColumn<string>(
                name: "Cd",
                table: "Sections",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cd",
                table: "Sections");

            migrationBuilder.AddColumn<int>(
                name: "Code",
                table: "Sections",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
