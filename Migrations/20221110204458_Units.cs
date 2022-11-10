using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UserStoryAir.Migrations
{
    public partial class Units : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReysBD",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    NumberReys = table.Column<decimal>(nullable: false),
                    Plane = table.Column<int>(nullable: false),
                    arrivalTime = table.Column<DateTime>(nullable: false),
                    NumberPassengers = table.Column<decimal>(nullable: false),
                    NumberCrew = table.Column<decimal>(nullable: false),
                    SborP = table.Column<decimal>(nullable: false),
                    SborC = table.Column<decimal>(nullable: false),
                    allowance = table.Column<decimal>(nullable: false),
                    Sum = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReysBD", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReysBD");
        }
    }
}
