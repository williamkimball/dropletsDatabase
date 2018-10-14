using Microsoft.EntityFrameworkCore.Migrations;

namespace DropletsDB.Migrations
{
    public partial class budgetItemAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_BudgetItem_UserId",
                table: "BudgetItem",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BudgetItem_User_UserId",
                table: "BudgetItem",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BudgetItem_User_UserId",
                table: "BudgetItem");

            migrationBuilder.DropIndex(
                name: "IX_BudgetItem_UserId",
                table: "BudgetItem");
        }
    }
}
