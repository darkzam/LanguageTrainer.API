using Microsoft.EntityFrameworkCore.Migrations;

namespace LanguageTrainer.API.Migrations
{
    public partial class SourceType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArticleId",
                table: "Mistakes");

            migrationBuilder.DropColumn(
                name: "Correct",
                table: "Mistakes");

            migrationBuilder.AddColumn<int>(
                name: "EntityId",
                table: "Sources",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SourceTypeId",
                table: "Sources",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Answer",
                table: "Mistakes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SourceId",
                table: "Mistakes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "SourceTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SourceTypes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SourceTypes");

            migrationBuilder.DropColumn(
                name: "EntityId",
                table: "Sources");

            migrationBuilder.DropColumn(
                name: "SourceTypeId",
                table: "Sources");

            migrationBuilder.DropColumn(
                name: "Answer",
                table: "Mistakes");

            migrationBuilder.DropColumn(
                name: "SourceId",
                table: "Mistakes");

            migrationBuilder.AddColumn<int>(
                name: "ArticleId",
                table: "Mistakes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Correct",
                table: "Mistakes",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
