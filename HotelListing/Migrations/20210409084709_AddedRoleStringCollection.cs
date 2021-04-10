using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListing.Migrations
{
    public partial class AddedRoleStringCollection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71157310-6878-446f-9d24-e64c8ba7fbfd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73333737-65d9-49cd-a7b2-6fbad4279618");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f49fc130-ac16-4579-b2c4-5821c0e40ca3", "13e40621-950a-447e-9fb7-4b22160540e6", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f8737a55-eb7e-4abd-8eaa-1ac0fb00c7b7", "c5e0b1f0-64c4-4c5b-8fcb-b89696e5b18c", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f49fc130-ac16-4579-b2c4-5821c0e40ca3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f8737a55-eb7e-4abd-8eaa-1ac0fb00c7b7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "71157310-6878-446f-9d24-e64c8ba7fbfd", "fbd4ce84-3579-4825-80de-5c69baff9592", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "73333737-65d9-49cd-a7b2-6fbad4279618", "c53e580d-caa4-4bdc-94da-4bee16ee3ec7", "Administrator", "ADMINISTRATOR" });
        }
    }
}
