using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KidsAndMeDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddPerson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Babies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    CreatureType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Babies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BabyFoodAttempts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FoodType = table.Column<int>(type: "int", nullable: false),
                    ConsumptionType = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EatingDuration = table.Column<double>(type: "float", nullable: false),
                    FoodSupply = table.Column<int>(type: "int", nullable: false),
                    ChildReaction = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BabyFoodAttempts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BathAttempts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BathAttempts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MomFoodAttempts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FoodType = table.Column<int>(type: "int", nullable: false),
                    ConsumptionType = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EatingDuration = table.Column<double>(type: "float", nullable: false),
                    FoodSupply = table.Column<int>(type: "int", nullable: false),
                    ChildReaction = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MomFoodAttempts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SleepAttempts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SleepAttempts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SleepReminders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SleepReminders", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Babies");

            migrationBuilder.DropTable(
                name: "BabyFoodAttempts");

            migrationBuilder.DropTable(
                name: "BathAttempts");

            migrationBuilder.DropTable(
                name: "MomFoodAttempts");

            migrationBuilder.DropTable(
                name: "SleepAttempts");

            migrationBuilder.DropTable(
                name: "SleepReminders");
        }
    }
}
