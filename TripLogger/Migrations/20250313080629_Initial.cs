using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TripLogger.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TripId",
                table: "Trips",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "AccommodationId",
                table: "Trips",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Trips",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Trips",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Trips");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Trips",
                newName: "TripId");

            migrationBuilder.AlterColumn<int>(
                name: "AccommodationId",
                table: "Trips",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
