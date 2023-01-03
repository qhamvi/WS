using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WS.Data.Migrations
{
    public partial class UpdateSeed_V3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "Stories",
                columns: new[] { "IdStory", "Author", "Collector", "CreateDate", "ImageFileName", "IsAcept", "IsComplete", "NumberChap", "PublishDate", "Summary", "TitleStory" },
                values: new object[,]
                {
                    { "28887e0e-b47b-44b5-bce7-274658f14c31", "Tac gia", "Nguoi suu tam", new DateTime(2022, 12, 29, 16, 19, 53, 339, DateTimeKind.Local).AddTicks(9099), "null.jpg", true, false, 0, new DateTime(2022, 12, 29, 16, 19, 53, 341, DateTimeKind.Local).AddTicks(4046), "Tom tat", "Tieu de truyen 3" },
                    { "c7f95997-e1e6-4714-bf21-c4ac5d3ac4b2", "Tac gia 2", "Nguoi suu tam 2", new DateTime(2022, 12, 29, 16, 19, 53, 341, DateTimeKind.Local).AddTicks(5453), "null.jpg", true, false, 0, new DateTime(2022, 12, 29, 16, 19, 53, 341, DateTimeKind.Local).AddTicks(5478), "Tom tat 2", "Tieu de truyen 3" },
                    { "0c162623-fda4-46a3-b647-d8dd7a60b21c", "Tac gia 3", "Nguoi suu tam 3", new DateTime(2022, 12, 29, 16, 19, 53, 341, DateTimeKind.Local).AddTicks(5517), "null.jpg", true, false, 0, new DateTime(2022, 12, 29, 16, 19, 53, 341, DateTimeKind.Local).AddTicks(5519), "Tom tat 3", "Tieu de truyen 3" }
                });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "IdTopic", "NameTopic" },
                values: new object[,]
                {
                    { "3c7d4dfd-8fdc-4bf5-8fe8-1c33afd8eb7a", "Tien hiep" },
                    { "2959b043-e266-4397-ba66-0beef768c72b", "Kiem hiep" }
                });

            migrationBuilder.InsertData(
                table: "Chapters",
                columns: new[] { "IdChapter", "Collector", "Content", "CreateDate", "IdStory", "TitleChap" },
                values: new object[] { new Guid("b964e204-3d89-4478-b993-c5e2df10b214"), "Nguoi suu tam", "Noi dung", new DateTime(2022, 12, 29, 16, 19, 53, 341, DateTimeKind.Local).AddTicks(6806), "28887e0e-b47b-44b5-bce7-274658f14c31", "Tieu de chap 1" });

            migrationBuilder.InsertData(
                table: "Chapters",
                columns: new[] { "IdChapter", "Collector", "Content", "CreateDate", "IdStory", "TitleChap" },
                values: new object[] { new Guid("27cddef8-0ff7-47eb-952c-4ff5706a190e"), "Nguoi suu tam", "Noi dung", new DateTime(2022, 12, 29, 16, 19, 53, 341, DateTimeKind.Local).AddTicks(8502), "28887e0e-b47b-44b5-bce7-274658f14c31", "Tieu de chap 2" });

            migrationBuilder.InsertData(
                table: "Chapters",
                columns: new[] { "IdChapter", "Collector", "Content", "CreateDate", "IdStory", "TitleChap" },
                values: new object[] { new Guid("9a660bb4-8913-4a7c-abc3-b85ffab71500"), "Nguoi suu tam", "Noi dung", new DateTime(2022, 12, 29, 16, 19, 53, 341, DateTimeKind.Local).AddTicks(8580), "28887e0e-b47b-44b5-bce7-274658f14c31", "Tieu de chap 3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Chapters",
                keyColumn: "IdChapter",
                keyValue: new Guid("27cddef8-0ff7-47eb-952c-4ff5706a190e"));

            migrationBuilder.DeleteData(
                table: "Chapters",
                keyColumn: "IdChapter",
                keyValue: new Guid("9a660bb4-8913-4a7c-abc3-b85ffab71500"));

            migrationBuilder.DeleteData(
                table: "Chapters",
                keyColumn: "IdChapter",
                keyValue: new Guid("b964e204-3d89-4478-b993-c5e2df10b214"));

            migrationBuilder.DeleteData(
                table: "Stories",
                keyColumn: "IdStory",
                keyValue: "0c162623-fda4-46a3-b647-d8dd7a60b21c");

            migrationBuilder.DeleteData(
                table: "Stories",
                keyColumn: "IdStory",
                keyValue: "c7f95997-e1e6-4714-bf21-c4ac5d3ac4b2");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "IdTopic",
                keyValue: "2959b043-e266-4397-ba66-0beef768c72b");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "IdTopic",
                keyValue: "3c7d4dfd-8fdc-4bf5-8fe8-1c33afd8eb7a");

            migrationBuilder.DeleteData(
                table: "Stories",
                keyColumn: "IdStory",
                keyValue: "28887e0e-b47b-44b5-bce7-274658f14c31");

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
    }
}
