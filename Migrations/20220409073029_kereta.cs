using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Traveler.Migrations
{
    public partial class kereta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tb_Kereta",
                columns: table => new
                {
                    kode_kereta = table.Column<string>(type: "varchar(767)", nullable: false),
                    nama_kereta = table.Column<string>(type: "text", nullable: true),
                    stasiun_asal = table.Column<string>(type: "text", nullable: true),
                    stasiun_tujuan = table.Column<string>(type: "text", nullable: true),
                    berangkat = table.Column<DateTime>(type: "datetime", nullable: false),
                    image = table.Column<string>(type: "text", nullable: true),
                    harga = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Kereta", x => x.kode_kereta);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tb_Kereta");
        }
    }
}
