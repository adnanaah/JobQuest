using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeminarskiRad_JobQuest.Migrations
{
    /// <inheritdoc />
    public partial class AccountIsDeletedUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Poslodavac",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Aplikant",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Administrator",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Poslodavac");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Aplikant");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Administrator");
        }
    }
}
