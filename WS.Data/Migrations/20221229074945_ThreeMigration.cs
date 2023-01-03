using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WS.Data.Migrations
{
    public partial class ThreeMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chapters_Users_UserId",
                table: "Chapters");

            migrationBuilder.DropForeignKey(
                name: "FK_Stories_Users_UserId",
                table: "Stories");

            migrationBuilder.DropForeignKey(
                name: "FK_TopicInStorys_Stories_IdStory",
                table: "TopicInStorys");

            migrationBuilder.DropForeignKey(
                name: "FK_TopicInStorys_Topics_IdTopic",
                table: "TopicInStorys");

            migrationBuilder.DropIndex(
                name: "IX_Stories_UserId",
                table: "Stories");

            migrationBuilder.DropIndex(
                name: "IX_Chapters_UserId",
                table: "Chapters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TopicInStorys",
                table: "TopicInStorys");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Stories");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Chapters");

            migrationBuilder.RenameTable(
                name: "TopicInStorys",
                newName: "TopicInStory");

            migrationBuilder.RenameIndex(
                name: "IX_TopicInStorys_IdTopic",
                table: "TopicInStory",
                newName: "IX_TopicInStory_IdTopic");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TopicInStory",
                table: "TopicInStory",
                columns: new[] { "IdStory", "IdTopic" });

            migrationBuilder.CreateTable(
                name: "UserHistoryChapters",
                columns: table => new
                {
                    IdUser = table.Column<Guid>(nullable: false),
                    IdChapter = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserHistoryChapters", x => new { x.IdUser, x.IdChapter });
                    table.ForeignKey(
                        name: "FK_UserHistoryChapters_Chapters_IdChapter",
                        column: x => x.IdChapter,
                        principalTable: "Chapters",
                        principalColumn: "IdChapter",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserHistoryChapters_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLikeStories",
                columns: table => new
                {
                    IdUser = table.Column<Guid>(nullable: false),
                    IdStory = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLikeStories", x => new { x.IdUser, x.IdStory });
                    table.ForeignKey(
                        name: "FK_UserLikeStories_Stories_IdStory",
                        column: x => x.IdStory,
                        principalTable: "Stories",
                        principalColumn: "IdStory",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserLikeStories_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserHistoryChapters_IdChapter",
                table: "UserHistoryChapters",
                column: "IdChapter");

            migrationBuilder.CreateIndex(
                name: "IX_UserLikeStories_IdStory",
                table: "UserLikeStories",
                column: "IdStory");

            migrationBuilder.AddForeignKey(
                name: "FK_TopicInStory_Stories_IdStory",
                table: "TopicInStory",
                column: "IdStory",
                principalTable: "Stories",
                principalColumn: "IdStory",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TopicInStory_Topics_IdTopic",
                table: "TopicInStory",
                column: "IdTopic",
                principalTable: "Topics",
                principalColumn: "IdTopic",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TopicInStory_Stories_IdStory",
                table: "TopicInStory");

            migrationBuilder.DropForeignKey(
                name: "FK_TopicInStory_Topics_IdTopic",
                table: "TopicInStory");

            migrationBuilder.DropTable(
                name: "UserHistoryChapters");

            migrationBuilder.DropTable(
                name: "UserLikeStories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TopicInStory",
                table: "TopicInStory");

            migrationBuilder.RenameTable(
                name: "TopicInStory",
                newName: "TopicInStorys");

            migrationBuilder.RenameIndex(
                name: "IX_TopicInStory_IdTopic",
                table: "TopicInStorys",
                newName: "IX_TopicInStorys_IdTopic");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Stories",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Chapters",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TopicInStorys",
                table: "TopicInStorys",
                columns: new[] { "IdStory", "IdTopic" });

            migrationBuilder.CreateIndex(
                name: "IX_Stories_UserId",
                table: "Stories",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Chapters_UserId",
                table: "Chapters",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chapters_Users_UserId",
                table: "Chapters",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Stories_Users_UserId",
                table: "Stories",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TopicInStorys_Stories_IdStory",
                table: "TopicInStorys",
                column: "IdStory",
                principalTable: "Stories",
                principalColumn: "IdStory",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TopicInStorys_Topics_IdTopic",
                table: "TopicInStorys",
                column: "IdTopic",
                principalTable: "Topics",
                principalColumn: "IdTopic",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
