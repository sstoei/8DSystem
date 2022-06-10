using Microsoft.EntityFrameworkCore.Migrations;

namespace _8DSystem.Migrations
{
    public partial class EditD5_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CauseSourceId",
                table: "D5_Action");

            migrationBuilder.AddColumn<int>(
                name: "RefCauseSourceId",
                table: "D5_Action",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_D5_Action_RefCauseSourceId",
                table: "D5_Action",
                column: "RefCauseSourceId");

            migrationBuilder.AddForeignKey(
                name: "FK_D5_Action_RefCauseSource_RefCauseSourceId",
                table: "D5_Action",
                column: "RefCauseSourceId",
                principalTable: "RefCauseSource",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_D5_Action_RefCauseSource_RefCauseSourceId",
                table: "D5_Action");

            migrationBuilder.DropIndex(
                name: "IX_D5_Action_RefCauseSourceId",
                table: "D5_Action");

            migrationBuilder.DropColumn(
                name: "RefCauseSourceId",
                table: "D5_Action");

            migrationBuilder.AddColumn<int>(
                name: "CauseSourceId",
                table: "D5_Action",
                type: "int",
                nullable: true);
        }
    }
}
