using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class first9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8203fed8-43ec-4aca-8e71-0079fcef4197", "1cdd665c-6608-4ff6-9454-aacd598c5177", "admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8203fed8-43ec-4aca-8e71-0079fcef4197");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1", "e0d9a826-dfaa-425b-9295-5468d88883df", "Admin", "ADMIN" });
        }
    }
}
