using Microsoft.EntityFrameworkCore.Migrations;

namespace Helishop.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoryName = table.Column<string>(nullable: true),
                    desc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Helicopter",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    image = table.Column<string>(nullable: true),
                    price = table.Column<int>(nullable: false),
                    issueYear = table.Column<int>(nullable: false),
                    fuel = table.Column<string>(nullable: true),
                    flightRange = table.Column<int>(nullable: false),
                    flightHours = table.Column<int>(nullable: false),
                    enginesCount = table.Column<int>(nullable: false),
                    categoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Helicopter", x => x.id);
                    table.ForeignKey(
                        name: "FK_Helicopter_Category_categoryID",
                        column: x => x.categoryID,
                        principalTable: "Category",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Helicopter_categoryID",
                table: "Helicopter",
                column: "categoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Helicopter");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
