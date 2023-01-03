using Microsoft.EntityFrameworkCore.Migrations;

namespace WS.Data.Migrations
{
    public partial class TwoMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Topics_Stories_StoryIdStory",
                table: "Topics");

            migrationBuilder.DropIndex(
                name: "IX_Topics_StoryIdStory",
                table: "Topics");

            migrationBuilder.DropColumn(
                name: "StoryIdStory",
                table: "Topics");

            migrationBuilder.CreateTable(
                name: "TopicInStorys",
                columns: table => new
                {
                    IdTopic = table.Column<string>(nullable: false),
                    IdStory = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopicInStorys", x => new { x.IdStory, x.IdTopic });
                    table.ForeignKey(
                        name: "FK_TopicInStorys_Stories_IdStory",
                        column: x => x.IdStory,
                        principalTable: "Stories",
                        principalColumn: "IdStory",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TopicInStorys_Topics_IdTopic",
                        column: x => x.IdTopic,
                        principalTable: "Topics",
                        principalColumn: "IdTopic",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TopicInStorys_IdTopic",
                table: "TopicInStorys",
                column: "IdTopic");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TopicInStorys");

            migrationBuilder.AddColumn<string>(
                name: "StoryIdStory",
                table: "Topics",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Topics_StoryIdStory",
                table: "Topics",
                column: "StoryIdStory");

            migrationBuilder.AddForeignKey(
                name: "FK_Topics_Stories_StoryIdStory",
                table: "Topics",
                column: "StoryIdStory",
                principalTable: "Stories",
                principalColumn: "IdStory",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
