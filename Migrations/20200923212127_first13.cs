using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class first13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba516e88-43ff-435f-9387-7ea3ff2b7027");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c600b5c2-ddf7-4ba3-8c1f-9d1b54ee3c47", "db1ce5af-a314-4f9a-a22e-fc44ea175b20", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c600b5c2-ddf7-4ba3-8c1f-9d1b54ee3c47");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ba516e88-43ff-435f-9387-7ea3ff2b7027", "71b8aa4f-2145-4917-982f-8b292e51ef56", "Admin", "ADMIN" });
        }
    }
}
