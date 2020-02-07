using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCDatabase.Migrations
{
    public partial class AddMigrationInitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Testing",
                table: "Item",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Testing",
                table: "Item");
        }
    }
}
