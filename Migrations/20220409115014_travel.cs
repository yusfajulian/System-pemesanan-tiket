using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Traveler.Migrations
{
    public partial class travel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tb_Travel",
                columns: table => new
                {
                    kode_travel = table.Column<string>(type: "varchar(767)", nullable: false),
                    nama_travel = table.Column<string>(type: "text", nullable: true),
                    kota_asal = table.Column<string>(type: "text", nullable: true),
                    kota_tujuan = table.Column<string>(type: "text", nullable: true),
                    berangkat = table.Column<DateTime>(type: "datetime", nullable: false),
                    image = table.Column<string>(type: "text", nullable: true),
                    harga = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Travel", x => x.kode_travel);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tb_Travel");
        }
    }
}
