using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BZRForumMedia.Server.Data.Migrations
{
    public partial class Propis : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.CreateTable(
                name: "Podrubrike",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Podrubrike", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rubrike",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rubrike", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VrstePropisa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VrstePropisa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Propisi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdRubrika = table.Column<int>(type: "int", nullable: true),
                    IdPodrubrika = table.Column<int>(type: "int", nullable: true),
                    Naslov = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GlasiloIDatum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TekstPropisa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdVrstaPropis = table.Column<int>(type: "int", nullable: true),
                    Donosilac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NivoVazenja = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatumStupanjaNaSnaguPropisa = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DatumPrestankaVerzije = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DatumObjavljivanjeVerzije = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DatumObjavljivanjaOsnovnogTeksta = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DatumStupanjaNaSnaguMedjunarodnogUgovora = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DatumStupanjaNaSnaguOsnovnogTeksta = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DatumPrestankaVazenjaPropisa = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DatumPocetkaPrimene = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PravniOsnovZaDonosenjePropisa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormaOsnovaZaDonosenje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropisKojiJePrestaoDaVazi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormaOsnovaZaPrestanakVazenja = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatumPrestankaVazenjaPravnogPrethodnika = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IstorijskaVerzijaPropisa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Napomena = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NapomenaGlasnika = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propisi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Propisi_Podrubrike_IdPodrubrika",
                        column: x => x.IdPodrubrika,
                        principalTable: "Podrubrike",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Propisi_Rubrike_IdRubrika",
                        column: x => x.IdRubrika,
                        principalTable: "Rubrike",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Propisi_VrstePropisa_IdVrstaPropis",
                        column: x => x.IdVrstaPropis,
                        principalTable: "VrstePropisa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Propisi_IdPodrubrika",
                table: "Propisi",
                column: "IdPodrubrika");

            migrationBuilder.CreateIndex(
                name: "IX_Propisi_IdRubrika",
                table: "Propisi",
                column: "IdRubrika");

            migrationBuilder.CreateIndex(
                name: "IX_Propisi_IdVrstaPropis",
                table: "Propisi",
                column: "IdVrstaPropis");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Propisi");

            migrationBuilder.DropTable(
                name: "Podrubrike");

            migrationBuilder.DropTable(
                name: "Rubrike");

            migrationBuilder.DropTable(
                name: "VrstePropisa");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
