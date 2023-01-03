using Microsoft.EntityFrameworkCore.Migrations;

namespace WS.Data.Migrations
{
    public partial class UpdateSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "IdTopic", "NameTopic" },
                values: new object[] { "95f8adf2-5059-4b53-b786-f9208c523af1", "Tien hiep" });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "IdTopic", "NameTopic" },
                values: new object[] { "8ee323a0-cbde-46de-adac-0b124f836a52", "Kiem hiep" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "IdTopic",
                keyValue: "8ee323a0-cbde-46de-adac-0b124f836a52");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "IdTopic",
                keyValue: "95f8adf2-5059-4b53-b786-f9208c523af1");
        }
    }
}
