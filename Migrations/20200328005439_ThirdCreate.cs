using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsEvents2.Migrations
{
    public partial class ThirdCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PreferedSport",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
                //name: "PreferedSport",
                //table: "AspNetUsers");
        }
    }
}
