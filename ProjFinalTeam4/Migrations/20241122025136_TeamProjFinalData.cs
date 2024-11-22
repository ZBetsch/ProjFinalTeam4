using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjFinalTeam4.Migrations
{
    /// <inheritdoc />
    public partial class TeamProjFinalData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExtracurricularActivity",
                columns: table => new
                {
                    activityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    activityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    activityDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    activityLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    activitySchedule = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtracurricularActivity", x => x.activityId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExtracurricularActivity");
        }
    }
}
