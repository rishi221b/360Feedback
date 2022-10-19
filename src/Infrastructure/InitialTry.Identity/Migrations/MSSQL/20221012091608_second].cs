using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InitialTry.Identity.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a972e02-bd92-4f19-b68e-072717c524dc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ccacba83-5872-438b-826a-16d418032e23");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1317837e-7120-4c81-bb25-4c6525b9938a", "2500bee0-5526-4ba6-835e-1e31fbc526a2", "Viewer", "VIEWER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "44517615-4993-4e97-a678-fcce966eed75", "b4258fb4-04de-43de-ae36-0d0d8cc08394", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1317837e-7120-4c81-bb25-4c6525b9938a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44517615-4993-4e97-a678-fcce966eed75");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0a972e02-bd92-4f19-b68e-072717c524dc", "8978dd6c-909b-402f-beab-846c9e03fa2a", "Viewer", "VIEWER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ccacba83-5872-438b-826a-16d418032e23", "908d4509-95d6-495d-b13e-c52e4f6e7e49", "Administrator", "ADMINISTRATOR" });
        }
    }
}
