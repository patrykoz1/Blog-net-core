using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class first12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6d80764e-b3b3-46e3-9f02-875518d15174");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ba516e88-43ff-435f-9387-7ea3ff2b7027", "71b8aa4f-2145-4917-982f-8b292e51ef56", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba516e88-43ff-435f-9387-7ea3ff2b7027");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6d80764e-b3b3-46e3-9f02-875518d15174", "0d7d22a5-383e-4e3f-a3e7-0cdde1968bd5", "Admin", "ADMIN" });
        }
    }
}
