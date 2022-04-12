using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fitness.Data.Migrations
{
    public partial class BlogEntity_BlotTitleToIEnum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogEntities_BlogTitle_BlogTitlesId",
                table: "BlogEntities");

            migrationBuilder.DropIndex(
                name: "IX_BlogEntities_BlogTitlesId",
                table: "BlogEntities");

            migrationBuilder.DropColumn(
                name: "BlogTitlesId",
                table: "BlogEntities");

            migrationBuilder.AddColumn<int>(
                name: "BlogEntityId",
                table: "BlogTitle",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BlogTitle_BlogEntityId",
                table: "BlogTitle",
                column: "BlogEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogTitle_BlogEntities_BlogEntityId",
                table: "BlogTitle",
                column: "BlogEntityId",
                principalTable: "BlogEntities",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogTitle_BlogEntities_BlogEntityId",
                table: "BlogTitle");

            migrationBuilder.DropIndex(
                name: "IX_BlogTitle_BlogEntityId",
                table: "BlogTitle");

            migrationBuilder.DropColumn(
                name: "BlogEntityId",
                table: "BlogTitle");

            migrationBuilder.AddColumn<int>(
                name: "BlogTitlesId",
                table: "BlogEntities",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BlogEntities_BlogTitlesId",
                table: "BlogEntities",
                column: "BlogTitlesId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogEntities_BlogTitle_BlogTitlesId",
                table: "BlogEntities",
                column: "BlogTitlesId",
                principalTable: "BlogTitle",
                principalColumn: "Id");
        }
    }
}
