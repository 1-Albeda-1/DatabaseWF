using Microsoft.EntityFrameworkCore.Migrations;

namespace UserStoryAir.Migrations
{
    public partial class AddProverka : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "proverka",
                table: "ReysBD",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "proverka",
                table: "ReysBD");
        }
    }
}
