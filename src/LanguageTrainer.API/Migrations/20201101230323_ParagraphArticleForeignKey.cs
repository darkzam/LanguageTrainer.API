using Microsoft.EntityFrameworkCore.Migrations;

namespace LanguageTrainer.API.Migrations
{
    public partial class ParagraphArticleForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArticleId",
                table: "Paragraphs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Paragraphs",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Paragraphs_ArticleId",
                table: "Paragraphs",
                column: "ArticleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Paragraphs_Articles_ArticleId",
                table: "Paragraphs",
                column: "ArticleId",
                principalTable: "Articles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paragraphs_Articles_ArticleId",
                table: "Paragraphs");

            migrationBuilder.DropIndex(
                name: "IX_Paragraphs_ArticleId",
                table: "Paragraphs");

            migrationBuilder.DropColumn(
                name: "ArticleId",
                table: "Paragraphs");

            migrationBuilder.DropColumn(
                name: "Content",
                table: "Paragraphs");
        }
    }
}
