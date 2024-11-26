using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjFinalTeam4.Migrations
{
    /// <inheritdoc />
    public partial class TeamDataMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TeamData",
                columns: table => new
                {
                    teamDataId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    teamDataFName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    teamDataLName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    teamDataBirthdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    teamDataCollegeProgram = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    teamDataProgramYear = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamData", x => x.teamDataId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeamData");
        }
    }
}
