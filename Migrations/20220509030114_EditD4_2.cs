using Microsoft.EntityFrameworkCore.Migrations;

namespace _8DSystem.Migrations
{
    public partial class EditD4_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_D4_FishBone_D4_D4Id",
                table: "D4_FishBone");

            migrationBuilder.DropForeignKey(
                name: "FK_D4_FishBone_RefCauseSource_RefCauseSourceId",
                table: "D4_FishBone");

            migrationBuilder.DropPrimaryKey(
                name: "PK_D4_FishBone",
                table: "D4_FishBone");

            migrationBuilder.RenameTable(
                name: "D4_FishBone",
                newName: "D4_CauseSource");

            migrationBuilder.RenameIndex(
                name: "IX_D4_FishBone_RefCauseSourceId",
                table: "D4_CauseSource",
                newName: "IX_D4_CauseSource_RefCauseSourceId");

            migrationBuilder.RenameIndex(
                name: "IX_D4_FishBone_D4Id",
                table: "D4_CauseSource",
                newName: "IX_D4_CauseSource_D4Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_D4_CauseSource",
                table: "D4_CauseSource",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_D4_CauseSource_D4_D4Id",
                table: "D4_CauseSource",
                column: "D4Id",
                principalTable: "D4",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_D4_CauseSource_RefCauseSource_RefCauseSourceId",
                table: "D4_CauseSource",
                column: "RefCauseSourceId",
                principalTable: "RefCauseSource",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_D4_CauseSource_D4_D4Id",
                table: "D4_CauseSource");

            migrationBuilder.DropForeignKey(
                name: "FK_D4_CauseSource_RefCauseSource_RefCauseSourceId",
                table: "D4_CauseSource");

            migrationBuilder.DropPrimaryKey(
                name: "PK_D4_CauseSource",
                table: "D4_CauseSource");

            migrationBuilder.RenameTable(
                name: "D4_CauseSource",
                newName: "D4_FishBone");

            migrationBuilder.RenameIndex(
                name: "IX_D4_CauseSource_RefCauseSourceId",
                table: "D4_FishBone",
                newName: "IX_D4_FishBone_RefCauseSourceId");

            migrationBuilder.RenameIndex(
                name: "IX_D4_CauseSource_D4Id",
                table: "D4_FishBone",
                newName: "IX_D4_FishBone_D4Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_D4_FishBone",
                table: "D4_FishBone",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_D4_FishBone_D4_D4Id",
                table: "D4_FishBone",
                column: "D4Id",
                principalTable: "D4",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_D4_FishBone_RefCauseSource_RefCauseSourceId",
                table: "D4_FishBone",
                column: "RefCauseSourceId",
                principalTable: "RefCauseSource",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
