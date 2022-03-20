using Microsoft.EntityFrameworkCore.Migrations;

namespace BZRForumMedia.Server.Data.Migrations
{
    public partial class UpdateTableClanciWithTekstClanka : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TekstClanka",
                table: "Clanci",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TekstClanka",
                table: "Clanci");
        }
    }
}
