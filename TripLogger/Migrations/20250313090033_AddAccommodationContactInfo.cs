using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TripLogger.Migrations
{
    /// <inheritdoc />
    public partial class AddAccommodationContactInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Trips");

            migrationBuilder.AlterColumn<int>(
                name: "AccommodationId",
                table: "Trips",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "AccommodationEmail",
                table: "Trips",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AccommodationPhoneNumber",
                table: "Trips",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccommodationEmail",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "AccommodationPhoneNumber",
                table: "Trips");

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
    }
}
