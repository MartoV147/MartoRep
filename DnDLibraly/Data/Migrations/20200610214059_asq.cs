using Microsoft.EntityFrameworkCore.Migrations;

namespace DnDLibraly.Data.Migrations
{
    public partial class asq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExpPoints",
                table: "Fights",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpPoints",
                table: "Fights");
        }
    }
}
