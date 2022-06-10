using Microsoft.EntityFrameworkCore.Migrations;

namespace _8DSystem.Migrations
{
    public partial class UpdateWorkFlow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkFlow_RefStatus_RefStatusId1",
                table: "WorkFlow");

            migrationBuilder.DropIndex(
                name: "IX_WorkFlow_RefStatusId1",
                table: "WorkFlow");

            migrationBuilder.DropColumn(
                name: "RefStatusId1",
                table: "WorkFlow");

            migrationBuilder.CreateIndex(
                name: "IX_WorkFlow_RefStatusId",
                table: "WorkFlow",
                column: "RefStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkFlow_RefStatus_RefStatusId",
                table: "WorkFlow",
                column: "RefStatusId",
                principalTable: "RefStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkFlow_RefStatus_RefStatusId",
                table: "WorkFlow");

            migrationBuilder.DropIndex(
                name: "IX_WorkFlow_RefStatusId",
                table: "WorkFlow");

            migrationBuilder.AddColumn<int>(
                name: "RefStatusId1",
                table: "WorkFlow",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkFlow_RefStatusId1",
                table: "WorkFlow",
                column: "RefStatusId1");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkFlow_RefStatus_RefStatusId1",
                table: "WorkFlow",
                column: "RefStatusId1",
                principalTable: "RefStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
