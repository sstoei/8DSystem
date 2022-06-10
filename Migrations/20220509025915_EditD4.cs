using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _8DSystem.Migrations
{
    public partial class EditD4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_D4_RefCauseSource_RefCauseSourceId",
                table: "D4");

            migrationBuilder.DropTable(
                name: "D4_FiveWhy");

            migrationBuilder.DropIndex(
                name: "IX_D4_RefCauseSourceId",
                table: "D4");

            migrationBuilder.DropColumn(
                name: "Environment",
                table: "D4_FishBone");

            migrationBuilder.DropColumn(
                name: "Machine",
                table: "D4_FishBone");

            migrationBuilder.DropColumn(
                name: "Main",
                table: "D4_FishBone");

            migrationBuilder.DropColumn(
                name: "Manufacturing",
                table: "D4_FishBone");

            migrationBuilder.DropColumn(
                name: "Material",
                table: "D4_FishBone");

            migrationBuilder.DropColumn(
                name: "Measurement",
                table: "D4_FishBone");

            migrationBuilder.DropColumn(
                name: "RefCauseSourceId",
                table: "D4");

            migrationBuilder.AddColumn<string>(
                name: "CauseDescription",
                table: "D4_FishBone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "D4_FishBone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RefCauseSourceId",
                table: "D4_FishBone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VerificationMethod",
                table: "D4_FishBone",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Verified",
                table: "D4_FishBone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DefineTheProblem",
                table: "D4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FishBone_Environment",
                table: "D4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FishBone_Machine",
                table: "D4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FishBone_Main",
                table: "D4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FishBone_Manufacturing",
                table: "D4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FishBone_Material",
                table: "D4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FishBone_Measurement",
                table: "D4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "How1",
                table: "D4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "How2",
                table: "D4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "How3",
                table: "D4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "How4",
                table: "D4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Why1",
                table: "D4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Why2",
                table: "D4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Why3",
                table: "D4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Why4",
                table: "D4",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_D4_FishBone_RefCauseSourceId",
                table: "D4_FishBone",
                column: "RefCauseSourceId");

            migrationBuilder.AddForeignKey(
                name: "FK_D4_FishBone_RefCauseSource_RefCauseSourceId",
                table: "D4_FishBone",
                column: "RefCauseSourceId",
                principalTable: "RefCauseSource",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_D4_FishBone_RefCauseSource_RefCauseSourceId",
                table: "D4_FishBone");

            migrationBuilder.DropIndex(
                name: "IX_D4_FishBone_RefCauseSourceId",
                table: "D4_FishBone");

            migrationBuilder.DropColumn(
                name: "CauseDescription",
                table: "D4_FishBone");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "D4_FishBone");

            migrationBuilder.DropColumn(
                name: "RefCauseSourceId",
                table: "D4_FishBone");

            migrationBuilder.DropColumn(
                name: "VerificationMethod",
                table: "D4_FishBone");

            migrationBuilder.DropColumn(
                name: "Verified",
                table: "D4_FishBone");

            migrationBuilder.DropColumn(
                name: "DefineTheProblem",
                table: "D4");

            migrationBuilder.DropColumn(
                name: "FishBone_Environment",
                table: "D4");

            migrationBuilder.DropColumn(
                name: "FishBone_Machine",
                table: "D4");

            migrationBuilder.DropColumn(
                name: "FishBone_Main",
                table: "D4");

            migrationBuilder.DropColumn(
                name: "FishBone_Manufacturing",
                table: "D4");

            migrationBuilder.DropColumn(
                name: "FishBone_Material",
                table: "D4");

            migrationBuilder.DropColumn(
                name: "FishBone_Measurement",
                table: "D4");

            migrationBuilder.DropColumn(
                name: "How1",
                table: "D4");

            migrationBuilder.DropColumn(
                name: "How2",
                table: "D4");

            migrationBuilder.DropColumn(
                name: "How3",
                table: "D4");

            migrationBuilder.DropColumn(
                name: "How4",
                table: "D4");

            migrationBuilder.DropColumn(
                name: "Why1",
                table: "D4");

            migrationBuilder.DropColumn(
                name: "Why2",
                table: "D4");

            migrationBuilder.DropColumn(
                name: "Why3",
                table: "D4");

            migrationBuilder.DropColumn(
                name: "Why4",
                table: "D4");

            migrationBuilder.AddColumn<string>(
                name: "Environment",
                table: "D4_FishBone",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Machine",
                table: "D4_FishBone",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Main",
                table: "D4_FishBone",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Manufacturing",
                table: "D4_FishBone",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Material",
                table: "D4_FishBone",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Measurement",
                table: "D4_FishBone",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RefCauseSourceId",
                table: "D4",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "D4_FiveWhy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    D4Id = table.Column<int>(type: "int", nullable: false),
                    DefineTheProblem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HowItHappening1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HowItHappening2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HowItHappening3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HowItHappening4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WhyIsHappening = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WhyIsThat2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WhyIsThat3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WhyIsThat4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D4_FiveWhy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D4_FiveWhy_D4_D4Id",
                        column: x => x.D4Id,
                        principalTable: "D4",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_D4_RefCauseSourceId",
                table: "D4",
                column: "RefCauseSourceId");

            migrationBuilder.CreateIndex(
                name: "IX_D4_FiveWhy_D4Id",
                table: "D4_FiveWhy",
                column: "D4Id");

            migrationBuilder.AddForeignKey(
                name: "FK_D4_RefCauseSource_RefCauseSourceId",
                table: "D4",
                column: "RefCauseSourceId",
                principalTable: "RefCauseSource",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
