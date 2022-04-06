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
                name: "Kelas",
                columns: table => new
                {
                    id_kelas = table.Column<string>(type: "varchar(767)", nullable: false),
                    nama = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kelas", x => x.id_kelas);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Email",
                columns: table => new
                {
                    NamaClientnya = table.Column<string>(type: "varchar(767)", nullable: false),
                    Portnya = table.Column<int>(type: "int", nullable: false),
                    EmailKita = table.Column<string>(type: "text", nullable: true),
                    PasswordEmailKita = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Email", x => x.NamaClientnya);
                });

            migrationBuilder.CreateTable(
                name: "Tb_JamKereta",
                columns: table => new
                {
                    id_jam = table.Column<string>(type: "varchar(767)", nullable: false),
                    jam_berangkat = table.Column<string>(type: "text", nullable: true),
                    jam_sampai = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_JamKereta", x => x.id_jam);
                });

            migrationBuilder.CreateTable(
                name: "Tb_JamPesawat",
                columns: table => new
                {
                    id_jam = table.Column<string>(type: "varchar(767)", nullable: false),
                    jam_berangkat = table.Column<string>(type: "text", nullable: true),
                    jam_sampai = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_JamPesawat", x => x.id_jam);
                });

            migrationBuilder.CreateTable(
                name: "Tb_JamTravel",
                columns: table => new
                {
                    id_jam = table.Column<string>(type: "varchar(767)", nullable: false),
                    jam_berangkat = table.Column<string>(type: "text", nullable: true),
                    jam_sampai = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_JamTravel", x => x.id_jam);
                });

            migrationBuilder.CreateTable(
                name: "Tb_JenisKereta",
                columns: table => new
                {
                    id_jenisker = table.Column<string>(type: "varchar(767)", nullable: false),
                    nama = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_JenisKereta", x => x.id_jenisker);
                });

            migrationBuilder.CreateTable(
                name: "Tb_JenisTravel",
                columns: table => new
                {
                    id_jenistrav = table.Column<string>(type: "varchar(767)", nullable: false),
                    nama = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_JenisTravel", x => x.id_jenistrav);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Maskapan",
                columns: table => new
                {
                    id_maskapai = table.Column<string>(type: "varchar(767)", nullable: false),
                    nama = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Maskapan", x => x.id_maskapai);
                });

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
                name: "Tb_Kereta",
                columns: table => new
                {
                    kode_kereta = table.Column<string>(type: "varchar(767)", nullable: false),
                    dari = table.Column<string>(type: "text", nullable: true),
                    ke = table.Column<string>(type: "text", nullable: true),
                    jenis_Keretaid_jenisker = table.Column<string>(type: "varchar(767)", nullable: true),
                    kelasid_kelas = table.Column<string>(type: "varchar(767)", nullable: true),
                    jam_Keretaid_jam = table.Column<string>(type: "varchar(767)", nullable: true),
                    jml_kursi = table.Column<int>(type: "int", nullable: false),
                    harga = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Kereta", x => x.kode_kereta);
                    table.ForeignKey(
                        name: "FK_Tb_Kereta_Kelas_kelasid_kelas",
                        column: x => x.kelasid_kelas,
                        principalTable: "Kelas",
                        principalColumn: "id_kelas",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tb_Kereta_Tb_JamKereta_jam_Keretaid_jam",
                        column: x => x.jam_Keretaid_jam,
                        principalTable: "Tb_JamKereta",
                        principalColumn: "id_jam",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tb_Kereta_Tb_JenisKereta_jenis_Keretaid_jenisker",
                        column: x => x.jenis_Keretaid_jenisker,
                        principalTable: "Tb_JenisKereta",
                        principalColumn: "id_jenisker",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Travel",
                columns: table => new
                {
                    kode_travel = table.Column<string>(type: "varchar(767)", nullable: false),
                    dari = table.Column<string>(type: "text", nullable: true),
                    ke = table.Column<string>(type: "text", nullable: true),
                    jenis_Travelid_jenistrav = table.Column<string>(type: "varchar(767)", nullable: true),
                    jam_Keretaid_jam = table.Column<string>(type: "varchar(767)", nullable: true),
                    jml_kursi = table.Column<int>(type: "int", nullable: false),
                    harga = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Travel", x => x.kode_travel);
                    table.ForeignKey(
                        name: "FK_Tb_Travel_Tb_JamKereta_jam_Keretaid_jam",
                        column: x => x.jam_Keretaid_jam,
                        principalTable: "Tb_JamKereta",
                        principalColumn: "id_jam",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tb_Travel_Tb_JenisTravel_jenis_Travelid_jenistrav",
                        column: x => x.jenis_Travelid_jenistrav,
                        principalTable: "Tb_JenisTravel",
                        principalColumn: "id_jenistrav",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Pesawat",
                columns: table => new
                {
                    kode_pesawat = table.Column<string>(type: "varchar(767)", nullable: false),
                    dari = table.Column<string>(type: "text", nullable: true),
                    ke = table.Column<string>(type: "text", nullable: true),
                    Maskapaiid_maskapai = table.Column<string>(type: "varchar(767)", nullable: true),
                    kelasid_kelas = table.Column<string>(type: "varchar(767)", nullable: true),
                    jam_Pesawatid_jam = table.Column<string>(type: "varchar(767)", nullable: true),
                    jml_kursi = table.Column<int>(type: "int", nullable: false),
                    harga = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Pesawat", x => x.kode_pesawat);
                    table.ForeignKey(
                        name: "FK_Tb_Pesawat_Kelas_kelasid_kelas",
                        column: x => x.kelasid_kelas,
                        principalTable: "Kelas",
                        principalColumn: "id_kelas",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tb_Pesawat_Tb_JamPesawat_jam_Pesawatid_jam",
                        column: x => x.jam_Pesawatid_jam,
                        principalTable: "Tb_JamPesawat",
                        principalColumn: "id_jam",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tb_Pesawat_Tb_Maskapan_Maskapaiid_maskapai",
                        column: x => x.Maskapaiid_maskapai,
                        principalTable: "Tb_Maskapan",
                        principalColumn: "id_maskapai",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Transaksi",
                columns: table => new
                {
                    id_transaksi = table.Column<string>(type: "varchar(767)", nullable: false),
                    Pelanggannik = table.Column<string>(type: "varchar(767)", nullable: true),
                    dari = table.Column<string>(type: "text", nullable: true),
                    ke = table.Column<string>(type: "text", nullable: true),
                    jml_orang = table.Column<int>(type: "int", nullable: false),
                    tgl_transaksi = table.Column<DateTime>(type: "datetime", nullable: false),
                    jam_berangkat = table.Column<string>(type: "text", nullable: true),
                    jam_sampai = table.Column<string>(type: "text", nullable: true),
                    harga = table.Column<int>(type: "int", nullable: false),
                    type_transaksi = table.Column<string>(type: "text", nullable: true)
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
                name: "IX_Tb_Kereta_jam_Keretaid_jam",
                table: "Tb_Kereta",
                column: "jam_Keretaid_jam");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Kereta_jenis_Keretaid_jenisker",
                table: "Tb_Kereta",
                column: "jenis_Keretaid_jenisker");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Kereta_kelasid_kelas",
                table: "Tb_Kereta",
                column: "kelasid_kelas");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Pesawat_jam_Pesawatid_jam",
                table: "Tb_Pesawat",
                column: "jam_Pesawatid_jam");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Pesawat_kelasid_kelas",
                table: "Tb_Pesawat",
                column: "kelasid_kelas");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Pesawat_Maskapaiid_maskapai",
                table: "Tb_Pesawat",
                column: "Maskapaiid_maskapai");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Transaksi_Pelanggannik",
                table: "Tb_Transaksi",
                column: "Pelanggannik");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Travel_jam_Keretaid_jam",
                table: "Tb_Travel",
                column: "jam_Keretaid_jam");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Travel_jenis_Travelid_jenistrav",
                table: "Tb_Travel",
                column: "jenis_Travelid_jenistrav");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_User_RolesId",
                table: "Tb_User",
                column: "RolesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tb_Email");

            migrationBuilder.DropTable(
                name: "Tb_JamTravel");

            migrationBuilder.DropTable(
                name: "Tb_Kereta");

            migrationBuilder.DropTable(
                name: "Tb_Pesawat");

            migrationBuilder.DropTable(
                name: "Tb_Transaksi");

            migrationBuilder.DropTable(
                name: "Tb_Travel");

            migrationBuilder.DropTable(
                name: "Tb_User");

            migrationBuilder.DropTable(
                name: "Tb_JenisKereta");

            migrationBuilder.DropTable(
                name: "Kelas");

            migrationBuilder.DropTable(
                name: "Tb_JamPesawat");

            migrationBuilder.DropTable(
                name: "Tb_Maskapan");

            migrationBuilder.DropTable(
                name: "Tb_Pelanggan");

            migrationBuilder.DropTable(
                name: "Tb_JamKereta");

            migrationBuilder.DropTable(
                name: "Tb_JenisTravel");

            migrationBuilder.DropTable(
                name: "Tb_Roles");
        }
    }
}
