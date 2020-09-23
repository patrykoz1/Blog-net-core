using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class first11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a98697a0-eaf9-4edb-ade6-83393da4311f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6d80764e-b3b3-46e3-9f02-875518d15174", "0d7d22a5-383e-4e3f-a3e7-0cdde1968bd5", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6d80764e-b3b3-46e3-9f02-875518d15174");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a98697a0-eaf9-4edb-ade6-83393da4311f", "06c3f18e-e957-409e-8922-9028814d5bfc", "Admin", "ADMIN" });
        }
    }
}
