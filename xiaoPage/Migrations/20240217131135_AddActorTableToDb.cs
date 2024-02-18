using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace xiaoPage.Migrations
{
    public partial class AddActorTableToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "actors",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Birthday = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_actors", x => x.ID);
                });

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
            migrationBuilder.DropTable(
                name: "actors");
        }
    }
}
