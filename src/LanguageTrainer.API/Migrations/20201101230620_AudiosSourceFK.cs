using Microsoft.EntityFrameworkCore.Migrations;

namespace LanguageTrainer.API.Migrations
{
    public partial class AudiosSourceFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SourceId",
                table: "Audios",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Audios_SourceId",
                table: "Audios",
                column: "SourceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Audios_Sources_SourceId",
                table: "Audios",
                column: "SourceId",
                principalTable: "Sources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Audios_Sources_SourceId",
                table: "Audios");

            migrationBuilder.DropIndex(
                name: "IX_Audios_SourceId",
                table: "Audios");

            migrationBuilder.DropColumn(
                name: "SourceId",
                table: "Audios");
        }
    }
}
