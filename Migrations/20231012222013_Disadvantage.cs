using Microsoft.EntityFrameworkCore.Migrations;

namespace MadMagnets.Migrations
{
    public partial class Disadvantage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Disadvantage",
                table: "Magnet",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Disadvantage",
                table: "Magnet");
        }
    }
}
