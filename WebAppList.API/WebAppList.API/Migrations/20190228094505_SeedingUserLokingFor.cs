using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppList.API.Migrations
{
    public partial class SeedingUserLokingFor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "lookingFor",
                table: "Users",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "lookingFor",
                table: "Users");
        }
    }
}
