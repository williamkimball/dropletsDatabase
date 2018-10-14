using Microsoft.EntityFrameworkCore.Migrations;

namespace DropletsDB.Migrations
{
    public partial class iduser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IdString",
                table: "User",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdString",
                table: "User");
        }
    }
}
