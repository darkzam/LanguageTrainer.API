using Microsoft.EntityFrameworkCore.Migrations;

namespace LanguageTrainer.API.Migrations
{
    public partial class SourceEntityModified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Sources");

            migrationBuilder.DropColumn(
                name: "EntityId",
                table: "Sources");

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Sources",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SourceTypeId",
                table: "Sources",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sources_SourceTypeId",
                table: "Sources",
                column: "SourceTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sources_SourceTypes_SourceTypeId",
                table: "Sources",
                column: "SourceTypeId",
                principalTable: "SourceTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sources_SourceTypes_SourceTypeId",
                table: "Sources");

            migrationBuilder.DropIndex(
                name: "IX_Sources_SourceTypeId",
                table: "Sources");

            migrationBuilder.DropColumn(
                name: "Content",
                table: "Sources");

            migrationBuilder.DropColumn(
                name: "SourceTypeId",
                table: "Sources");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Sources",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EntityId",
                table: "Sources",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
