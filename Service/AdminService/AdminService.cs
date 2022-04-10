using Microsoft.AspNetCore.Http;
using Traveler.Helper;
using Traveler.Models;
using Traveler.Repository.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Traveler.Service.File;

namespace Traveler.Service.AdminService
{
    public class AdminService : IAdminService
    {
        public readonly IAdminRevository _AdminRevo;
        private readonly FileService _file;
        public AdminService(IAdminRevository admin, FileService file)
        {
            _AdminRevo = admin;
            _file = file;
        }

        public async Task<bool> HapusKereta(string id)
        {
            var cari = await _AdminRevo.CariIdKereta(id);

            return await _AdminRevo.HapusKereta(cari);
        }

        public async Task<bool> HapusPelanggan(string id)
        {
            var cari = await _AdminRevo.CariId(id);

            return await _AdminRevo.HapusPelanggan(cari);
        }

        public async Task<bool> HapusPesawat(string id)
        {
            var cari = await _AdminRevo.CariIdPesawat(id);

            return await _AdminRevo.HapusPesawat(cari);
        }

        public async Task<bool> HapusTransaksi(string id)
        {
            var cari = await _AdminRevo.CariIdTransaksi(id);

            return await _AdminRevo.HapusTransaksi(cari);
        }

        public async Task<bool> HapusTravel(string id)
        {
            var cari = await _AdminRevo.CariIdTravel(id);

            return await _AdminRevo.HapusTravel(cari);
        }

        public async Task<bool> TambahKereta(Kereta parameter, IFormFile fotonya)
        {
            parameter.kode_kereta = Helper.BuatPrimary.buatPrimary();
            parameter.image = await _file.SimpanFile(fotonya);

            return await _AdminRevo.TambahKereta(parameter);
        }

        public async Task<bool> TambahPelanggan(Pelanggan baru)
        {
            return await _AdminRevo.TambahPelanggan(baru);
        }

        public async Task<bool> TambahPesawat(Pesawat parameter, IFormFile fotonya)
        {
            parameter.kode_pesawat = Helper.BuatPrimary.buatPrimary();
            parameter.image = await _file.SimpanFile(fotonya);

            return await _AdminRevo.TambahPesawat(parameter);
        }

        public async Task<bool> TambahTransaksi(transaksi transaksi, string data,string id)
        {
            transaksi.id_transaksi = BuatPrimary.buatPrimary();
            transaksi.Pelanggan = await _AdminRevo.CariId(data);
            transaksi.pesawat = await _AdminRevo.CariIdPesawat(id);

            return await _AdminRevo.TambahTransaksi(transaksi);
        }

        public async Task<bool> TambahTravel(Travel parameter, IFormFile fotonya)
        {
            parameter.kode_travel = Helper.BuatPrimary.buatPrimary();
            parameter.image = await _file.SimpanFile(fotonya);

            return await _AdminRevo.TambahTravel(parameter);
        }

        public Task<List<Kereta>> TampilSemuaKereta()
        {
            return _AdminRevo.TampilSemuaKereta();
        }

        public async Task<Kereta> TampilSemuaKeretaId(string id)
        {
            return await _AdminRevo.TampilSemuaKeretaId(id);
        }

        public Task<List<Pelanggan>> TampilSemuaPelanggan()
        {
            return _AdminRevo.TampilSemuaPelanggan();
        }

        public Task<List<Pesawat>> TampilSemuaPesawat()
        {
            return _AdminRevo.TampilSemuaPesawat();
        }

        public async Task<Pesawat> TampilSemuaPesawatId(string id)
        {
            return await _AdminRevo.TampilSemuaPesawatId(id);
        }

        public Task<List<transaksi>> TampilSemuaTransaksi()
        {
            return _AdminRevo.TampilSemuaTransaksi();
        }

        public Task<List<Travel>> TampilSemuaTravel()
        {
            return _AdminRevo.TampilSemuaTravel();
        }

        public async Task<Travel> TampilSemuaTravelId(string id)
        {
            return await _AdminRevo.TampilSemuaTravelId(id);
        }

        public async Task<bool> UbahKereta(Kereta datanya)
        {
            var cari = await _AdminRevo.CariIdKereta(datanya.kode_kereta);

            cari.image = datanya.image;
            cari.nama_kereta = datanya.nama_kereta;
            cari.stasiun_asal = datanya.stasiun_asal;
            cari.stasiun_tujuan = datanya.stasiun_tujuan;
            cari.berangkat = datanya.berangkat;
            cari.harga = datanya.harga;

            return await _AdminRevo.UbahKereta(cari);
        }

        public async Task<bool> UbahPesawat(Pesawat datanya)
        {
            var cari = await _AdminRevo.CariIdPesawat(datanya.kode_pesawat);

            cari.image = datanya.image;
            cari.Maskapai = datanya.Maskapai;
            cari.Bandara_asal = datanya.Bandara_asal;
            cari.Bandara_tujuan = datanya.Bandara_tujuan;
            cari.berangkat = datanya.berangkat;
            cari.harga = datanya.harga;

            return await _AdminRevo.UbahPesawat(cari);
        }

        public async Task<bool> UbahTravel(Travel datanya)
        {
            var cari = await _AdminRevo.CariIdTravel(datanya.kode_travel);

            cari.image = datanya.image;
            cari.nama_travel = datanya.nama_travel;
            cari.kota_asal = datanya.kota_asal;
            cari.kota_tujuan = datanya.kota_tujuan;
            cari.berangkat = datanya.berangkat;
            cari.harga = datanya.harga;

            return await _AdminRevo.UbahTravel(cari);
        }
    }
}
