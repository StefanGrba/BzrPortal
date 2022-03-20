using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BZRForumMedia.Server.Data.Migrations
{
    public partial class CreateDokumentacijaAndTipDokumentacija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipoviDokumentacije",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImeTipa = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoviDokumentacije", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dokumentacije",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naslov = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Autor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatumObjavljivanja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Tekst = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Napomena = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PdfPutanja = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WordPutanja = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdTipa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dokumentacije", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dokumentacije_TipoviDokumentacije_IdTipa",
                        column: x => x.IdTipa,
                        principalTable: "TipoviDokumentacije",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dokumentacije_IdTipa",
                table: "Dokumentacije",
                column: "IdTipa");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dokumentacije");

            migrationBuilder.DropTable(
                name: "TipoviDokumentacije");
        }
    }
}
