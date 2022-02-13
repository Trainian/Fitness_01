using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fitness.Data.Migrations
{
    public partial class BlogEntitys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogTitle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdBlog = table.Column<int>(type: "INTEGER", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Text = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogTitle", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BlogId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: true),
                    CommentText = table.Column<string>(type: "TEXT", nullable: false),
                    Show = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsVerified = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlogEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BlogName = table.Column<string>(type: "TEXT", nullable: false),
                    CreaterName = table.Column<string>(type: "TEXT", nullable: false),
                    DateCreate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    BlogText = table.Column<string>(type: "TEXT", nullable: false),
                    BlogImages = table.Column<string>(type: "TEXT", nullable: true),
                    BlogTags = table.Column<int>(type: "INTEGER", nullable: true),
                    CommentsId = table.Column<int>(type: "INTEGER", nullable: true),
                    BlogTitlesId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogEntities_BlogTitle_BlogTitlesId",
                        column: x => x.BlogTitlesId,
                        principalTable: "BlogTitle",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BlogEntities_Comment_CommentsId",
                        column: x => x.CommentsId,
                        principalTable: "Comment",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogEntities_BlogTitlesId",
                table: "BlogEntities",
                column: "BlogTitlesId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogEntities_CommentsId",
                table: "BlogEntities",
                column: "CommentsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogEntities");

            migrationBuilder.DropTable(
                name: "BlogTitle");

            migrationBuilder.DropTable(
                name: "Comment");
        }
    }
}
