using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppList.API.Migrations
{
    public partial class SeedingUserLokingFor2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "lookingFor",
                table: "Users",
                newName: "LookingFor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LookingFor",
                table: "Users",
                newName: "lookingFor");
        }
    }
}
