using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjFinalTeam4.Migrations
{
    /// <inheritdoc />
    public partial class HobbiesUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "hobbiesStart",
                table: "Hobbies",
                newName: "hobbiesStartYear");

            migrationBuilder.AddColumn<int>(
                name: "hobbiesStartDay",
                table: "Hobbies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "hobbiesStartMonth",
                table: "Hobbies",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "hobbiesStartDay",
                table: "Hobbies");

            migrationBuilder.DropColumn(
                name: "hobbiesStartMonth",
                table: "Hobbies");

            migrationBuilder.RenameColumn(
                name: "hobbiesStartYear",
                table: "Hobbies",
                newName: "hobbiesStart");
        }
    }
}
