using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _8DSystem.Migrations
{
    public partial class EditD3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "D3_Action",
                table: "D3");

            migrationBuilder.DropColumn(
                name: "D3_DateFinish",
                table: "D3");

            migrationBuilder.DropColumn(
                name: "D3_DateStart",
                table: "D3");

            migrationBuilder.DropColumn(
                name: "D3_Eff",
                table: "D3");

            migrationBuilder.DropColumn(
                name: "D3_Metric",
                table: "D3");

            migrationBuilder.DropColumn(
                name: "D3_PartId",
                table: "D3");

            migrationBuilder.DropColumn(
                name: "D3_TeamMember",
                table: "D3");

            migrationBuilder.DropColumn(
                name: "D3_TeamMemberEmail",
                table: "D3");

            migrationBuilder.DropColumn(
                name: "D3_TeamMemberName",
                table: "D3");

            migrationBuilder.AddColumn<bool>(
                name: "CopyFromD0",
                table: "D3",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "D3_Action",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    D3_Detail = table.Column<string>(nullable: true),
                    D3_TeamMember = table.Column<string>(maxLength: 7, nullable: true),
                    D3_TeamMemberName = table.Column<string>(nullable: true),
                    D3_TeamMemberEmail = table.Column<string>(nullable: true),
                    D3_DateStart = table.Column<DateTime>(nullable: true),
                    D3_DateFinish = table.Column<DateTime>(nullable: true),
                    D3_Metric = table.Column<decimal>(nullable: true),
                    D3_Eff = table.Column<decimal>(nullable: true),
                    D3_PartId = table.Column<string>(nullable: true),
                    D3Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D3_Action", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D3_Action_D3_D3Id",
                        column: x => x.D3Id,
                        principalTable: "D3",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_D3_Action_D3Id",
                table: "D3_Action",
                column: "D3Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "D3_Action");

            migrationBuilder.DropColumn(
                name: "CopyFromD0",
                table: "D3");

            migrationBuilder.AddColumn<string>(
                name: "D3_Action",
                table: "D3",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "D3_DateFinish",
                table: "D3",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "D3_DateStart",
                table: "D3",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "D3_Eff",
                table: "D3",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "D3_Metric",
                table: "D3",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "D3_PartId",
                table: "D3",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "D3_TeamMember",
                table: "D3",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "D3_TeamMemberEmail",
                table: "D3",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "D3_TeamMemberName",
                table: "D3",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
