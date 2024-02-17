using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace xiaoPage.Migrations
{
    public partial class SeedActorTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "actors",
                columns: new[] { "ID", "Birthday", "Name" },
                values: new object[] { 1, 1990, "Action" });

            migrationBuilder.InsertData(
                table: "actors",
                columns: new[] { "ID", "Birthday", "Name" },
                values: new object[] { 2, 2000, "history" });

            migrationBuilder.InsertData(
                table: "actors",
                columns: new[] { "ID", "Birthday", "Name" },
                values: new object[] { 3, 1993, "but" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "ID",
                keyValue: 3);
        }
    }
}
