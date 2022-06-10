using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _8DSystem.Migrations
{
    public partial class Add_D2_Attachment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "D2_AttachmentFailure",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(nullable: false),
                    Content = table.Column<byte[]>(nullable: false),
                    ContentName = table.Column<string>(nullable: false),
                    ContentMimeType = table.Column<string>(nullable: false),
                    D2Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D2_AttachmentFailure", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D2_AttachmentFailure_D2_D2Id",
                        column: x => x.D2Id,
                        principalTable: "D2",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "D2_AttachmentRecurring",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(nullable: false),
                    Content = table.Column<byte[]>(nullable: false),
                    ContentName = table.Column<string>(nullable: false),
                    ContentMimeType = table.Column<string>(nullable: false),
                    D2Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D2_AttachmentRecurring", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D2_AttachmentRecurring_D2_D2Id",
                        column: x => x.D2Id,
                        principalTable: "D2",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_D2_AttachmentFailure_D2Id",
                table: "D2_AttachmentFailure",
                column: "D2Id");

            migrationBuilder.CreateIndex(
                name: "IX_D2_AttachmentRecurring_D2Id",
                table: "D2_AttachmentRecurring",
                column: "D2Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "D2_AttachmentFailure");

            migrationBuilder.DropTable(
                name: "D2_AttachmentRecurring");
        }
    }
}
