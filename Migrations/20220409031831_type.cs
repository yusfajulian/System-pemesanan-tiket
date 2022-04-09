using Microsoft.EntityFrameworkCore.Migrations;

namespace Traveler.Migrations
{
    public partial class type : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "type",
                table: "Tb_Pelanggan",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "type",
                table: "Tb_Pelanggan");
        }
    }
}
