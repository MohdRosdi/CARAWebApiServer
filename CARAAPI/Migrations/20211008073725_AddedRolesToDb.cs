using Microsoft.EntityFrameworkCore.Migrations;

namespace CARAAPI.Migrations
{
    public partial class AddedRolesToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "33827aab-3c91-4d3b-b9ce-e74a4126bed1", "dcaae92c-20f9-4cbb-994a-728326dd6069", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d2e26205-db9e-4701-bba1-6873fb2dd696", "8a650153-624b-49a1-896e-6356a56f2259", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33827aab-3c91-4d3b-b9ce-e74a4126bed1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d2e26205-db9e-4701-bba1-6873fb2dd696");
        }
    }
}
