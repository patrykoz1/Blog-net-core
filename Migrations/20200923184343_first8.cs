using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class first8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Name" },
                values: new object[] { "e0d9a826-dfaa-425b-9295-5468d88883df", "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Name" },
                values: new object[] { "bb092f6b-1530-48ed-9b04-44e107ed57df", "admin" });
        }
    }
}
