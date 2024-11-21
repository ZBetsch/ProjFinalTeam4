using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjFinalTeam4.Migrations
{
    /// <inheritdoc />
    public partial class ProjFinalTeam4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Travel",
                columns: table => new
                {
                    travelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    travelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    travelCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    travelCost = table.Column<int>(type: "int", nullable: false),
                    travelDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Travel", x => x.travelId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Travel");
        }
    }
}
