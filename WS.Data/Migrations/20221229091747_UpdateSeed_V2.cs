using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WS.Data.Migrations
{
    public partial class UpdateSeed_V2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "IdTopic",
                keyValue: "8ee323a0-cbde-46de-adac-0b124f836a52");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "IdTopic",
                keyValue: "95f8adf2-5059-4b53-b786-f9208c523af1");

            migrationBuilder.InsertData(
                table: "Stories",
                columns: new[] { "IdStory", "Author", "Collector", "CreateDate", "ImageFileName", "IsAcept", "IsComplete", "NumberChap", "PublishDate", "Summary", "TitleStory" },
                values: new object[,]
                {
                    { "71986825-6c09-41f5-90ea-fc38b53aba60", "Tac gia", "Nguoi suu tam", new DateTime(2022, 12, 29, 16, 17, 46, 993, DateTimeKind.Local).AddTicks(526), "null.jpg", true, false, 0, new DateTime(2022, 12, 29, 16, 17, 46, 995, DateTimeKind.Local).AddTicks(1048), "Tom tat", "Tieu de truyen 3" },
                    { "75ff666d-203c-4f7f-9745-b4ef51434610", "Tac gia 2", "Nguoi suu tam 2", new DateTime(2022, 12, 29, 16, 17, 46, 995, DateTimeKind.Local).AddTicks(3026), "null.jpg", true, false, 0, new DateTime(2022, 12, 29, 16, 17, 46, 995, DateTimeKind.Local).AddTicks(3056), "Tom tat 2", "Tieu de truyen 3" },
                    { "55b5d8aa-0557-484e-85b4-96715d6d8bde", "Tac gia 3", "Nguoi suu tam 3", new DateTime(2022, 12, 29, 16, 17, 46, 995, DateTimeKind.Local).AddTicks(3109), "null.jpg", true, false, 0, new DateTime(2022, 12, 29, 16, 17, 46, 995, DateTimeKind.Local).AddTicks(3112), "Tom tat 3", "Tieu de truyen 3" }
                });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "IdTopic", "NameTopic" },
                values: new object[,]
                {
                    { "395fc0ad-7d66-4757-95dd-be92639b74f0", "Tien hiep" },
                    { "c8acf3b5-afb3-40f4-8743-3f4341e486dd", "Kiem hiep" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stories",
                keyColumn: "IdStory",
                keyValue: "55b5d8aa-0557-484e-85b4-96715d6d8bde");

            migrationBuilder.DeleteData(
                table: "Stories",
                keyColumn: "IdStory",
                keyValue: "71986825-6c09-41f5-90ea-fc38b53aba60");

            migrationBuilder.DeleteData(
                table: "Stories",
                keyColumn: "IdStory",
                keyValue: "75ff666d-203c-4f7f-9745-b4ef51434610");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "IdTopic",
                keyValue: "395fc0ad-7d66-4757-95dd-be92639b74f0");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "IdTopic",
                keyValue: "c8acf3b5-afb3-40f4-8743-3f4341e486dd");

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "IdTopic", "NameTopic" },
                values: new object[] { "95f8adf2-5059-4b53-b786-f9208c523af1", "Tien hiep" });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "IdTopic", "NameTopic" },
                values: new object[] { "8ee323a0-cbde-46de-adac-0b124f836a52", "Kiem hiep" });
        }
    }
}
