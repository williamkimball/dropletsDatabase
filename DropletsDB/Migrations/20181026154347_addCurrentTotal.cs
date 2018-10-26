using Microsoft.EntityFrameworkCore.Migrations;

namespace DropletsDB.Migrations
{
    public partial class addCurrentTotal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Current",
                table: "BudgetItem",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Current",
                table: "BudgetItem");
        }
    }
}
