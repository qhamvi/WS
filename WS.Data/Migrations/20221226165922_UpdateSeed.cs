using Microsoft.EntityFrameworkCore.Migrations;

namespace WS.Data.Migrations
{
    public partial class UpdateSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "IdTopic", "NameTopic", "StoryIdStory" },
                values: new object[] { "badc99e6-2314-4480-a3f4-34bb06260b6f", "Tiên hiệp", null });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "IdTopic", "NameTopic", "StoryIdStory" },
                values: new object[] { "e0ea92e0-f1ab-4b7c-a8c3-9d8bfb919cbb", "Kiếm hiệp", null });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "IdTopic", "NameTopic", "StoryIdStory" },
                values: new object[] { "4f1c3f45-eb91-41e3-9622-1057272aa338", "Ngôn tình", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "IdTopic",
                keyValue: "4f1c3f45-eb91-41e3-9622-1057272aa338");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "IdTopic",
                keyValue: "badc99e6-2314-4480-a3f4-34bb06260b6f");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "IdTopic",
                keyValue: "e0ea92e0-f1ab-4b7c-a8c3-9d8bfb919cbb");
        }
    }
}
