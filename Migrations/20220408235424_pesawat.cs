using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace Traveler.Migrations
{
    public partial class pesawat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tb_Pelanggan",
                columns: table => new
                {
                    nik = table.Column<string>(type: "varchar(767)", nullable: false),
                    nama_pelanggan = table.Column<string>(type: "text", nullable: false),
                    kartu_vaksin = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    no_telp = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Pelanggan", x => x.nik);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Pesawat",
                columns: table => new
                {
                    kode_pesawat = table.Column<string>(type: "varchar(767)", nullable: false),
                    Maskapai = table.Column<string>(type: "text", nullable: true),
                    Bandara_asal = table.Column<string>(type: "text", nullable: true),
                    Bandara_tujuan = table.Column<string>(type: "text", nullable: true),
                    berangkat = table.Column<DateTime>(type: "datetime", nullable: false),
                    image = table.Column<string>(type: "text", nullable: true),
                    harga = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Pesawat", x => x.kode_pesawat);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(767)", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Transaksi",
                columns: table => new
                {
                    id_transaksi = table.Column<string>(type: "varchar(767)", nullable: false),
                    Pelanggannik = table.Column<string>(type: "varchar(767)", nullable: true),
                    pesawatkode_pesawat = table.Column<string>(type: "varchar(767)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Transaksi", x => x.id_transaksi);
                    table.ForeignKey(
                        name: "FK_Tb_Transaksi_Tb_Pelanggan_Pelanggannik",
                        column: x => x.Pelanggannik,
                        principalTable: "Tb_Pelanggan",
                        principalColumn: "nik",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tb_Transaksi_Tb_Pesawat_pesawatkode_pesawat",
                        column: x => x.pesawatkode_pesawat,
                        principalTable: "Tb_Pesawat",
                        principalColumn: "kode_pesawat",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tb_User",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    RolesId = table.Column<string>(type: "varchar(767)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_User", x => x.id);
                    table.ForeignKey(
                        name: "FK_Tb_User_Tb_Roles_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Tb_Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Transaksi_Pelanggannik",
                table: "Tb_Transaksi",
                column: "Pelanggannik");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Transaksi_pesawatkode_pesawat",
                table: "Tb_Transaksi",
                column: "pesawatkode_pesawat");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_User_RolesId",
                table: "Tb_User",
                column: "RolesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tb_Transaksi");

            migrationBuilder.DropTable(
                name: "Tb_User");

            migrationBuilder.DropTable(
                name: "Tb_Pelanggan");

            migrationBuilder.DropTable(
                name: "Tb_Pesawat");

            migrationBuilder.DropTable(
                name: "Tb_Roles");
        }
    }
}
