using Microsoft.EntityFrameworkCore.Migrations;

namespace AHExercise.Migrations
{
    public partial class three : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Companies");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Companies",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
