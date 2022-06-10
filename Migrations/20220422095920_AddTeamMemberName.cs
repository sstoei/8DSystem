using Microsoft.EntityFrameworkCore.Migrations;

namespace _8DSystem.Migrations
{
    public partial class AddTeamMemberName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreateByEmail",
                table: "ReportHeader",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreateByName",
                table: "ReportHeader",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TeamMemberEmail",
                table: "D7_A",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TeamMemberName",
                table: "D7_A",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TeamMemberEmail",
                table: "D6_Action",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TeamMemberName",
                table: "D6_Action",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "D3_TeamMemberEmail",
                table: "D3",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "D3_TeamMemberName",
                table: "D3",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TeamMemberEmail",
                table: "D0_EmergencyRespondActio",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TeamMemberName",
                table: "D0_EmergencyRespondActio",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateByEmail",
                table: "ReportHeader");

            migrationBuilder.DropColumn(
                name: "CreateByName",
                table: "ReportHeader");

            migrationBuilder.DropColumn(
                name: "TeamMemberEmail",
                table: "D7_A");

            migrationBuilder.DropColumn(
                name: "TeamMemberName",
                table: "D7_A");

            migrationBuilder.DropColumn(
                name: "TeamMemberEmail",
                table: "D6_Action");

            migrationBuilder.DropColumn(
                name: "TeamMemberName",
                table: "D6_Action");

            migrationBuilder.DropColumn(
                name: "D3_TeamMemberEmail",
                table: "D3");

            migrationBuilder.DropColumn(
                name: "D3_TeamMemberName",
                table: "D3");

            migrationBuilder.DropColumn(
                name: "TeamMemberEmail",
                table: "D0_EmergencyRespondActio");

            migrationBuilder.DropColumn(
                name: "TeamMemberName",
                table: "D0_EmergencyRespondActio");
        }
    }
}
