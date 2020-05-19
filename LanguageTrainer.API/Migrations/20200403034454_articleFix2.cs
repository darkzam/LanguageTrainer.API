using Microsoft.EntityFrameworkCore.Migrations;

namespace LanguageTrainer.API.Migrations
{
    public partial class articleFix2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SourceTypeId",
                table: "Sources");

            migrationBuilder.AddColumn<int>(
                name: "SourceTypeId",
                table: "Articles",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SourceTypeId",
                table: "Articles");

            migrationBuilder.AddColumn<int>(
                name: "SourceTypeId",
                table: "Sources",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
