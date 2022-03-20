using Microsoft.EntityFrameworkCore.Migrations;

namespace BZRForumMedia.Server.Data.Migrations
{
    public partial class UserTableUpdateWithPozicijaAndNazivKompanije : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NazivKompanije",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NazivRadnogMesta",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NazivKompanije",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NazivRadnogMesta",
                table: "AspNetUsers");
        }
    }
}
