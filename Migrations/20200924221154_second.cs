using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c600b5c2-ddf7-4ba3-8c1f-9d1b54ee3c47");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "37bedef1-23b5-460d-8a88-dee644c80048", "b8da5bb9-d731-4820-8d7f-3d6e6faab972", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37bedef1-23b5-460d-8a88-dee644c80048");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c600b5c2-ddf7-4ba3-8c1f-9d1b54ee3c47", "db1ce5af-a314-4f9a-a22e-fc44ea175b20", "Admin", "ADMIN" });
        }
    }
}
