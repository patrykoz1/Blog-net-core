using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class first7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Name" },
                values: new object[] { "bb092f6b-1530-48ed-9b04-44e107ed57df", "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Name" },
                values: new object[] { "999bd43b-9f88-4ac2-88e6-c9a589e335b9", "ADMIN" });
        }
    }
}
