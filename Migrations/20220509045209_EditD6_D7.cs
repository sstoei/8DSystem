using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _8DSystem.Migrations
{
    public partial class EditD6_D7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "D7_DateClosure",
                table: "D7");

            migrationBuilder.DropColumn(
                name: "D6_DateClosure",
                table: "D6");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "D7_DateClosure",
                table: "D7",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "D6_DateClosure",
                table: "D6",
                type: "datetime2",
                nullable: true);
        }
    }
}
