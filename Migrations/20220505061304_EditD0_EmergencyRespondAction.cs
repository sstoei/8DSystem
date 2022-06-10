using Microsoft.EntityFrameworkCore.Migrations;

namespace _8DSystem.Migrations
{
    public partial class EditD0_EmergencyRespondAction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_D0_EmergencyRespondActio_D0_D0Id",
                table: "D0_EmergencyRespondActio");

            migrationBuilder.DropPrimaryKey(
                name: "PK_D0_EmergencyRespondActio",
                table: "D0_EmergencyRespondActio");

            migrationBuilder.RenameTable(
                name: "D0_EmergencyRespondActio",
                newName: "D0_EmergencyRespondAction");

            migrationBuilder.RenameIndex(
                name: "IX_D0_EmergencyRespondActio_D0Id",
                table: "D0_EmergencyRespondAction",
                newName: "IX_D0_EmergencyRespondAction_D0Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_D0_EmergencyRespondAction",
                table: "D0_EmergencyRespondAction",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_D0_EmergencyRespondAction_D0_D0Id",
                table: "D0_EmergencyRespondAction",
                column: "D0Id",
                principalTable: "D0",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_D0_EmergencyRespondAction_D0_D0Id",
                table: "D0_EmergencyRespondAction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_D0_EmergencyRespondAction",
                table: "D0_EmergencyRespondAction");

            migrationBuilder.RenameTable(
                name: "D0_EmergencyRespondAction",
                newName: "D0_EmergencyRespondActio");

            migrationBuilder.RenameIndex(
                name: "IX_D0_EmergencyRespondAction_D0Id",
                table: "D0_EmergencyRespondActio",
                newName: "IX_D0_EmergencyRespondActio_D0Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_D0_EmergencyRespondActio",
                table: "D0_EmergencyRespondActio",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_D0_EmergencyRespondActio_D0_D0Id",
                table: "D0_EmergencyRespondActio",
                column: "D0Id",
                principalTable: "D0",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
