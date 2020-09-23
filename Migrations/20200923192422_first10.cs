using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class first10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8203fed8-43ec-4aca-8e71-0079fcef4197");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a98697a0-eaf9-4edb-ade6-83393da4311f", "06c3f18e-e957-409e-8922-9028814d5bfc", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a98697a0-eaf9-4edb-ade6-83393da4311f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8203fed8-43ec-4aca-8e71-0079fcef4197", "1cdd665c-6608-4ff6-9454-aacd598c5177", "admin", "ADMIN" });
        }
    }
}
