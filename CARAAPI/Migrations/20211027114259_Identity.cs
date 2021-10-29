using Microsoft.EntityFrameworkCore.Migrations;

namespace CARAAPI.Migrations
{
    public partial class Identity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3d7a8c3c-ff96-4cca-b589-31509cb3e532", "2bab47c6-1b1b-41a1-8c0a-f1bf150a087c", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a72cdcb6-9028-4576-b3de-28e311a6de27", "f4f1a486-3fbb-4d0c-b973-838561dd4f91", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d7a8c3c-ff96-4cca-b589-31509cb3e532");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a72cdcb6-9028-4576-b3de-28e311a6de27");
        }
    }
}
