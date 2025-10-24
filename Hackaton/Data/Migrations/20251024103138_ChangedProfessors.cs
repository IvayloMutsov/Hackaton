using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hackaton.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangedProfessors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsReserve",
                table: "Proffessors");

            migrationBuilder.DropColumn(
                name: "ParticipationCounter",
                table: "Proffessors");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsReserve",
                table: "Proffessors",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ParticipationCounter",
                table: "Proffessors",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
