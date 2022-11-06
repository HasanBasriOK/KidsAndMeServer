using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KidsAndMeDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddUsernameAndPasswordToCreature : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Babies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Babies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Babies");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Babies");
        }
    }
}
