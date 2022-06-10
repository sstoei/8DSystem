using Microsoft.EntityFrameworkCore.Migrations;

namespace _8DSystem.Migrations
{
    public partial class EditD5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_D5_RefCauseSource_RefCauseSourceId",
                table: "D5");

            migrationBuilder.DropIndex(
                name: "IX_D5_RefCauseSourceId",
                table: "D5");

            migrationBuilder.DropColumn(
                name: "RefCauseSourceId",
                table: "D5");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RefCauseSourceId",
                table: "D5",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_D5_RefCauseSourceId",
                table: "D5",
                column: "RefCauseSourceId");

            migrationBuilder.AddForeignKey(
                name: "FK_D5_RefCauseSource_RefCauseSourceId",
                table: "D5",
                column: "RefCauseSourceId",
                principalTable: "RefCauseSource",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
