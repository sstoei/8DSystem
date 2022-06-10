using Microsoft.EntityFrameworkCore.Migrations;

namespace _8DSystem.Migrations
{
    public partial class Edit_D5_D6_D7_D8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Detail",
                table: "D8",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Detail",
                table: "D7",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Detail",
                table: "D6",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Detail",
                table: "D5",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Detail",
                table: "D8");

            migrationBuilder.DropColumn(
                name: "Detail",
                table: "D7");

            migrationBuilder.DropColumn(
                name: "Detail",
                table: "D6");

            migrationBuilder.DropColumn(
                name: "Detail",
                table: "D5");
        }
    }
}
