using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjFinalTeam4.Migrations
{
    /// <inheritdoc />
    public partial class TeamProjFinalDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hobbies",
                columns: table => new
                {
                    hobbiesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hobbiesName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hobbiesDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hobbiesStart = table.Column<int>(type: "int", nullable: false),
                    hobbiesResources = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobbies", x => x.hobbiesId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hobbies");
        }
    }
}
