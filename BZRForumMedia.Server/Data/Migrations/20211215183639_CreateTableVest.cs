using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BZRForumMedia.Server.Data.Migrations
{
    public partial class CreateTableVest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vesti",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naslov = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tekst = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatumObjavljivanja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Podnaslov = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sazetak = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PutanjaDoSlike = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vesti", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vesti");
        }
    }
}
